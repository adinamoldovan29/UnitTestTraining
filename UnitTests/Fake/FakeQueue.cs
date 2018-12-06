using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using UnitTestTraining.Fake;

namespace UnitTests.Fake
{
    public class FakeQueue : IQueue
    {
        public List<Message> Messages { get; private set; }
           
        public void Add(Message message)
        {
            Messages = new List<Message>();
            Messages.Add(message);
        }

        public Message Read()
        {
            var nextMessage = Messages.FirstOrDefault();
            Messages.RemoveAt(0);

            return nextMessage;
        }

        public void DeleteAll()
        {
            Messages.Clear();
        }
    }
}
