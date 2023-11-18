using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace M320ChatBot3
{
    public class Storage
    {
        public List<Message> Messages { get; private set; } = new List<Message>();

        public void Load()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            string resourceName = "ChatBot.responses.txt";

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
