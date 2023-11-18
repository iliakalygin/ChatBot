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

        // The constructor initializes the MainWindow and the BotEngine.
        public MainWindow()
        {
            InitializeComponent();
            botEngine = new BotEngine();
        }

        // This method is called when the "Send" button is clicked.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = InputBox.Text;
            ChatBox.AppendText("You: " + input + Environment.NewLine);

            var response = botEngine.GetAnswer(input);
            ChatBox.AppendText("Bot: " + response + Environment.NewLine);

            InputBox.Clear();
        }
    }
}