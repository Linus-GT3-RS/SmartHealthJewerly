using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackendCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Tests
{
    [TestClass()]
    public class BufferTests
    {
        [TestMethod()]
        public void CapacityTest()
        {
            Buffer data = new Buffer(1);
            data.Write(1);
            Assert.ThrowsException<InvalidOperationException>(() => data.Write(1));
        }

        [TestMethod()]
        public void WriteReadTest()
        {
            Buffer data = new Buffer(5);
            data.Write(15);
            Assert.AreEqual(15, data.Read());
        }
    }
}