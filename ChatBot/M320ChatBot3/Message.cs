using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320ChatBot3
{
    // Definiert die Message-Klasse, die ein Schlüsselwort und eine dazugehörige Antwort speichert.
    public class Message
    {
        // Das Schlüsselwort, auf das der Chatbot reagieren soll.
        // Das Fragezeichen markiert den String als "nullable", sodass er auch null sein kann.
        public string? Keyword { get; set; }

        // Die Antwort, die der Chatbot geben soll, wenn das Schlüsselwort erkannt wird.
        // Das Fragezeichen markiert den String als "nullable", sodass er auch null sein kann.
        public string? Answer { get; set; }
    }
}
