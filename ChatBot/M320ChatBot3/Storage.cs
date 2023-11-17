using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace M320ChatBot3
{
    // Definiert die Storage-Klasse, die für das Laden von Nachrichten aus einer Ressourcendatei verantwortlich ist.
    public class Storage
    {
        // Eine Liste von Message-Objekten, die die geladenen Nachrichten speichern.
        public List<Message> Messages { get; private set; } = new List<Message>();

        // Die Load-Methode ist verantwortlich für das Laden der Nachrichten aus der Ressourcendatei.
        public void Load()
        {
            // Holt die ausführende Assembly (in diesem Fall die Assembly dieser Anwendung).
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Definiert den Namen der Ressourcendatei, die die Nachrichten enthält.
            string resourceName = "M320ChatBot3.responses.txt";

            // Öffnet einen Stream zur Ressourcendatei und einen StreamReader zum Lesen des Streams.
            using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream ?? throw new InvalidOperationException("Stream cannot be null")))
            {
                // Liest jede Zeile der Ressourcendatei.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Zerteilt jede Zeile in Schlüsselwort und Antwort, getrennt durch ein "=".
                    var parts = line.Split('=');

                    // Fügt die Nachricht zur Liste hinzu, wenn beide Teile vorhanden sind.
                    if (parts.Length == 2)
                    {
                        Messages.Add(new Message { Keyword = parts[0].Trim(), Answer = parts[1].Trim() });
                    }
                }
            }
        }
    }
}
