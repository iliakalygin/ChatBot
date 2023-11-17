using M320ChatBot3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace ChatBot
{
    // Die MainWindow-Klasse ist die Hauptklasse für die Benutzeroberfläche und steuert die Interaktion mit dem Benutzer.
    public partial class MainWindow : Window
    {
        // Ein BotEngine-Objekt, das für die Verarbeitung der Nachrichten und die Rückgabe von Antworten verantwortlich ist.
        private BotEngine botEngine;

        // Der Konstruktor initialisiert die MainWindow und die BotEngine.
        public MainWindow()
        {
            InitializeComponent(); // Initialisiert die Komponenten der Benutzeroberfläche.
            botEngine = new BotEngine(); // Erstellt ein neues BotEngine-Objekt.
        }

        // Diese Methode wird aufgerufen, wenn der "Senden"-Knopf geklickt wird.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Holt den Text aus dem InputBox-Textfeld.
            var input = InputBox.Text;

            // Fügt die Benutzereingabe zum ChatBox-Textfeld hinzu.
            ChatBox.AppendText("Du: " + input + Environment.NewLine);

            // Holt die Antwort des Bots auf die Benutzereingabe.
            var response = botEngine.GetAnswer(input);

            // Fügt die Bot-Antwort zum ChatBox-Textfeld hinzu.
            ChatBox.AppendText("Bot: " + response + Environment.NewLine);

            // Leert das InputBox-Textfeld.
            InputBox.Clear();
        }
    }
}