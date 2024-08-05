﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Bingo.Classes.Buttons
{
    public class BingoFindButton : Button, IBingoButton
    {
        public int id;
        public bool currentState = false;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string IBingoButton.Content
        {
            get { return (string)Content; }
            set { Content = value; }
        }

        bool IBingoButton.CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public event EventHandler ButtonClicked;

        public BingoFindButton()
        {
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;
            Margin = new Thickness(5);
            Width = 80;
            Height = 80;
            Click += (s, e) => OnClick();
            Background = Brushes.LightGray;
            Padding = new Thickness(5);
        }

        private event EventHandler _onClick;
        event EventHandler IBingoButton.OnClick
        {
            add
            {
                _onClick += value;
            }
            remove
            {
                _onClick -= value;
            }
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnClick()
        {
            Debug.WriteLine(Content);
            if (!currentState)
            {
                Background = new SolidColorBrush(Colors.Red);
                currentState = true;
            }
            else
            {
                Background = new SolidColorBrush(Colors.LightGray);
                    currentState = false;
            }
            OnButtonClicked(EventArgs.Empty);
            _onClick?.Invoke(this, EventArgs.Empty);
        }

        public Button GetButton()
        {
            return this;
        }
    }
}