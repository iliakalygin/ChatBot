using M320ChatBot3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace ChatBot
{
    public partial class MainWindow : Window
    {
        private BotEngine botEngine;

        public MainWindow()
        {
            InitializeComponent(); 
            botEngine = new BotEngine(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = InputBox.Text;

            ChatBox.AppendText("Du: " + input + Environment.NewLine);

            var response = botEngine.GetAnswer(input);

            ChatBox.AppendText("Bot: " + response + Environment.NewLine);

            InputBox.Clear();
        }
    }
}