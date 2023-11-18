using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320ChatBot3
{
    public class BotEngine
    {
        private List<Message> messages;
        private Storage storage;
        public BotEngine()
        {
            storage = new Storage();
            storage.Load();
            messages = storage.Messages;
        }

        public string GetAnswer(string keyword)
        {
            var message = messages.FirstOrDefault(m => m.Keyword.Equals(keyword, StringComparison.OrdinalIgnoreCase));

            return message?.Answer ?? "Ich verstehe das nicht.";
        }
    }
}
