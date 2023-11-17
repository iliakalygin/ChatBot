using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320ChatBot3
{
    // Die BotEngine-Klasse ist für die Verarbeitung der Nachrichten und die Rückgabe von Antworten verantwortlich.
    public class BotEngine
    {
        // Eine Liste von Message-Objekten, die die Nachrichten speichert.
        private List<Message> messages;

        // Ein Storage-Objekt, das für das Laden der Nachrichten aus einer Ressource oder einer Datei verantwortlich ist.
        private Storage storage;

        // Der Konstruktor initialisiert die BotEngine und lädt die Nachrichten.
        public BotEngine()
        {
            // Erstellt ein neues Storage-Objekt und lädt die Nachrichten.
            storage = new Storage();
            storage.Load();

            // Speichert die geladenen Nachrichten in der messages-Liste.
            messages = storage.Messages;
        }

        // Die GetAnswer-Methode gibt eine Antwort basierend auf dem gegebenen Schlüsselwort zurück.
        public string GetAnswer(string keyword)
        {
            // Sucht die erste Nachricht, deren Schlüsselwort dem gegebenen Schlüsselwort entspricht.
            var message = messages.FirstOrDefault(m => m.Keyword.Equals(keyword, StringComparison.OrdinalIgnoreCase));

            // Gibt die zugehörige Antwort zurück oder einen Standardtext, wenn keine passende Nachricht gefunden wurde.
            return message?.Answer ?? "Ich verstehe das nicht.";
        }
    }
}
