﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.CompilerServices;
using System.Windows.Xps.Serialization;
using System.Diagnostics;
using Bingo.Classes;
using System.Data;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Bingo
{
  

    public enum Multi
    {
        Solo=0,
        Serwer=1,
        Klient=2
    }
    public class Siec
    {
        private static int testCzekania = 0;
        private static int BoardSize { get; set; } = 5;
        private static GameType gameType { get; set; } = GameType.Numbers;
        private static Categories Category { get; set; } = Categories.Empty;

        static private EventHandler zamykanie = new EventHandler(GameWindow_Closed);

        static private GameManager gameManager;

        static TcpListener server;
        static TcpClient client;
        static string IP;
        static bool czySerwer;
        static GameWindow gameWindow;
        static string  wiadomosc="";
        static string msgSerwer="";
        static string msgClient="";
        static string[] dekode;
        static bool oponentWin = false;
        static int firstMsg = 0;

        static Thread receiveThread;
        static Thread sendThread;
        static Thread graThread;

        static public void GameWindow_Closed(object sender, EventArgs e)
        {
            Debug.WriteLine("Wylacza sie");
            receiveThread.Abort();
            sendThread.Abort();
            graThread.Abort();

            receiveThread.Join();
            sendThread.Join();
            graThread.Join();
            Application.Current.Shutdown();
        }

        public static string DecodeBase64ToIp(string encoded)
        {

            byte[] bytes = Convert.FromBase64String(encoded);

            if (bytes.Length != 4)
            {
                throw new ArgumentException("Zakodowany ciąg nie jest prawidłowym adresem IP.");
            }

            string ipAddress = string.Join(".", bytes);
            return ipAddress;
        }

        public Siec(Multi multi,string ip,int bSize, GameType gType, Categories cat)
        {
            gameType = gType;
            Category = cat;
            BoardSize= bSize;
            switch (multi)
            {
                case Multi.Serwer:
                    StartServer(bSize,gType,cat);
                    break;
                case Multi.Klient:
                    IP = DecodeBase64ToIp(ip);
                    StartClient(bSize,gType,cat);
                    break;
                default:
                    break;
            }
            gameManager = new GameManager(gType, cat, gameWindow, czySerwer);
        }



        //nie tykać
        static async Task StartServer(int bSize, GameType gType, Categories Cat)
        {
            
            Application.Current.Dispatcher.Invoke(() =>
            {
                gameWindow = new GameWindow(bSize, gType, Cat, gameManager);
                gameWindow.Title = "Server";
                gameWindow.Show();
                gameWindow.Closed += zamykanie;
            });

            czySerwer= true;
            IPAddress ipAddress = IPAddress.Parse(GetLocalIPAddress());
            
            int port = 12345;

            server = new TcpListener(ipAddress, port);
            server.Start();
            Debug.WriteLine("Serwer uruchomiony...");
            Debug.WriteLine("Oczekiwanie na drugiego gracza...");

           
            client = await server.AcceptTcpClientAsync();
            gameManager.StartTimer();
            Debug.WriteLine("Połączono z klientem.");
           

            receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();

            sendThread = new Thread(SendMessages);
            sendThread.Start();

            graThread = new Thread(Gra);
            graThread.Start();

        }
       

        static async Task StartClient(int bSize, GameType gType, Categories Cat)
        {

            Application.Current.Dispatcher.Invoke(() =>
            {
                gameWindow = new GameWindow(BoardSize, gameType, Category, gameManager);
                gameWindow.Title = "Client";
                gameWindow.Show();
                gameWindow.Closed += zamykanie;
            });

            czySerwer = false;
            string serverIp = IP;
            int serverPort = 12345;

            client = new TcpClient();
            Debug.WriteLine("Łączenie z klientem...");
            await client.ConnectAsync(serverIp, serverPort);


           // gameManager.StartTimer();

            Debug.WriteLine("Połączono z serwerem.");

            receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();

            sendThread = new Thread(SendMessages);
            sendThread.Start();

            graThread = new Thread(Gra);
            graThread.Start();
        }

        static string GetLocalIPAddress()
        {
            string ipAddress = "";
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }

            return ipAddress;
        }

        static void ReceiveMessages()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            try
            {
                if (czySerwer)
                {
                    while (true)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //wiadomosc przesylana z klienta
                        //Debug.WriteLine(message + '\n');
                        msgSerwer = message;
                    }
                }
                else
                {
                    while (true)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //wiadomosc przesylana z serwera
                        //Debug.WriteLine(message + '\n');
                        msgClient = message;
                    }
                }
            }
            catch 
            {
                Thread.CurrentThread.Interrupt();
            }
        }

        static void SendMessages()
        {
            NetworkStream stream = client.GetStream();
            try
            {
                if (czySerwer)
                {
                    while (true)
                    {
                        Thread.Sleep(250);
                        Przesylana();

                        string message = wiadomosc;
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        stream.Write(data, 0, data.Length);
                    }
                }
                else
                {
                    while (true)
                    {
                        Thread.Sleep(225);
                        Przesylana();

                        string message = wiadomosc;
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        stream.Write(data, 0, data.Length);

                    }
                }
            }
            catch
            {
                Thread.CurrentThread.Interrupt();
            }


        }


        //przesyłana jest 'wiadomosc'
        static void Przesylana()
        {
            try
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (czySerwer)
                    {
                        if (firstMsg<4&&client.Connected)
                        {
                            wiadomosc = gameType 
                            + " " + Category 
                            + " " + BoardSize
                            + " " + firstMsg;
                            firstMsg++;
                        }
                        else
                        {
                            wiadomosc = gameWindow.numer()
                            + " " + gameWindow.txbTimer.Text.ToString()
                            + " " + gameWindow.winner.ToString();
                        }
                    }
                    else
                    {
                        wiadomosc = gameWindow.winner.ToString();
                    }
                });
            }
            catch
            {
                Thread.CurrentThread.Interrupt();
            }
        }
        static void Gra()
        {

            while (true)
            {
                try
                {
                    Thread.Sleep(500);

                    //tu setery/getery szzczególne dla  
                    //msgSerwer/msgClient -to informacja DLA Serwera/Klienta
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        if (!client.Connected)
                        {
                            MessageBox.Show("Utracono połączenie");
                            gameWindow.Close();
                        }

                        if (czySerwer)
                        {
                            dekode = msgSerwer.Split(' ');
                            oponentWin=bool.Parse(dekode[0]);
                        }
                        else
                        {
                            dekode = msgClient.Split(" ");
                            if (dekode.Length ==4 && firstMsg == 0 &&client.Connected)
                            {
                                try
                                {
                                    Debug.WriteLine("Test wiadomosci " + msgClient);
                                    //gameType + " " + Category + " " + BoardSize + " " + firstMsg;
                                    gameType=Enum.Parse<GameType>(dekode[0]);
                                    Category=Enum.Parse<Categories>(dekode[1]);
                                    BoardSize=Int16.Parse(dekode[2]);
                                    firstMsg =Int16.Parse(dekode[3]);
                                    Debug.WriteLine(gameType + " " + Category + " " + BoardSize + " " + firstMsg);
                                    Debug.WriteLine(gameType.ToString());
                                    gameWindow.SetProperties(gameType, Category, BoardSize);
                                }
                                catch { }
                            }
                            else if(dekode.Length==3){
                                gameWindow.txbGeneratedNumber.Text = dekode[0];
                                //musi być
                                if (dekode.Length > 1)
                                {
                                    gameWindow.txbTimer.Text = dekode[1];
                                    oponentWin = bool.Parse(dekode[2]);
                                }
                            }
                        }
                        if(oponentWin)
                        {
                            MessageBox.Show("Oponent wygrał");
                            gameWindow.Close();
                        }
                    });
                }
                catch
                {
                    Thread.CurrentThread.Interrupt();
                }
            }
        }
    }
}
