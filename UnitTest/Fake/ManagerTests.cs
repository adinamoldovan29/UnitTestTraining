using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTestTraining.Fake;

namespace UnitTests.Fake
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void CreateMessage_Valid_MessageCreated()
        {
            // Arange
            var fakeQueue = new FakeQueue();
            var manager = new Manager(fakeQueue);

            // Act
            manager.CreateMessage("validMessage");

            // Assert
            Assert.AreEqual(1, fakeQueue.Messages.Count);
        }

        [TestMethod]
        public void CreateMessage_Corupt_MessageNotCreated()
        {
            // Arange
            var fakeQueue = new FakeQueue();
            var manager = new Manager(fakeQueue);

            // Act
            manager.CreateMessage("IsCorupt");

            // Assert
            Assert.AreEqual(0, fakeQueue.Messages.Count);
        }

        [TestMethod]
        public void CreateMessage_Virus_DeleteAllMessages()
        {
            // Arange
            var fakeQueue = new FakeQueue()
            {
                Messages = new List<Message>()
                    { new Message("mes1"), new Message("mes2"), new Message("mes3")}
            };
            var manager = new Manager(fakeQueue);

            // Act
            manager.CreateMessage("IsVirus");

            // Assert
            Assert.AreEqual(0, fakeQueue.Messages.Count);
        }
    }
}
