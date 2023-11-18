using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace M320ChatBot3
{
    // Defines the storage class that is responsible for loading messages from a resource file.
    public class Storage
    {
        public List<Message> Messages { get; private set; } = new List<Message>();

        // The load method is responsible for loading the messages from the resource file.
        public void Load()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Defines the name of the resource file that contains the messages.
            string resourceName = "M320ChatBot3.responses.txt";

            // Opens a stream to the resource file and a StreamReader to read the stream.
            using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream ?? throw new InvalidOperationException("Stream cannot be null")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        Messages.Add(new Message { Keyword = parts[0].Trim(), Answer = parts[1].Trim() });
                    }
                }
            }
        }
    }
}
