using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320ChatBot3
{
    // Defines the message class that stores a keyword and an associated response.
    public class Message
    {
        public string? Keyword { get; set; }
        public string? Answer { get; set; }
    }
}
