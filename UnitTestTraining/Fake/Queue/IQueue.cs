using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UnitTestTraining.Fake
{
    public interface IQueue
    {
        void Add(Message message);

        void DeleteAll();
    }
}
