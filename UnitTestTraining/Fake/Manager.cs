using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnitTestTraining.Fake
{
    public class Manager
    {
        private IQueue queue;

        public Manager(IQueue queue)
        {
            this.queue = queue;
        }

        public void CreateMessage(string text)
        {
            if (IsVirus(text))
            {
                queue.DeleteAll();
                return;
            }

            if (!IsCorupt(text))
            {
                queue.Add(new Message(text));
                return;
            }
        }

        private bool IsVirus(string text) 
            => text.Contains("IsVirus", StringComparison.CurrentCultureIgnoreCase);
        

        private bool IsCorupt(string text) =>
            text.Contains("IsCorupt", StringComparison.CurrentCultureIgnoreCase);
    }
}
