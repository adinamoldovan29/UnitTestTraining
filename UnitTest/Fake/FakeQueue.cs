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
        public  List<Message> Messages = new List<Message>();

        public void Add(Message message)
        {
            Messages.Add(message);
        }

        public void DeleteAll()
        {
            Messages.Clear();
        }
    }
}
