using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320ChatBot3
{
    // The BotEngine class is responsible for processing the messages and returning responses.
    public class BotEngine
    {
        private List<Message> messages;
        private Storage storage;

        // Constructor initializes the BotEngine and loads the messages.
        public BotEngine()
        {
            // Creates a new storage object and loads the messages.
            storage = new Storage();
            storage.Load();

            // Saves the loaded messages in the messages list.
            messages = storage.Messages;
        }

        // The GetAnswer method returns an answer based on the given keyword.
        public string GetAnswer(string keyword)
        {
            var message = messages.FirstOrDefault(m => m.Keyword.Equals(keyword, StringComparison.OrdinalIgnoreCase));

            return message?.Answer ?? "I dont understand that.";
        }
    }
}
