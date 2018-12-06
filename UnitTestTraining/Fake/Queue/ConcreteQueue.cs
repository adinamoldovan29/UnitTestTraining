using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestTraining.Fake
{
    public class ConcreteQueue : IQueue
    {
        public void Add(Message message)
        {
            // add messages on a real queue
        }

        public void DeleteAll()
        {
            // delete all the messages from a real queue
        }
    }
}
