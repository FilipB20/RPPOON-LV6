using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter writer = new StreamWriter(this.filePath,true))
            {
                writer.Write((type + ": " + DateTime.Now.ToString()));
                writer.Write(new string('=', message.Length));
                writer.Write(message);
                writer.Write(new string('=', message.Length) + "\n");
            }


        }

    }
}
