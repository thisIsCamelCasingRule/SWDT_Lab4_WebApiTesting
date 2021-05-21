using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWDT_Lab4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUpload()
        {
            HttpStatusCode result = Class1.GetUpload();
            Assert.AreEqual(HttpStatusCode.OK, result);
        }

        [TestMethod]
        public void TestGetFileMetadata()
        {
            HttpStatusCode result = Class1.GetFileMetadata();
            Assert.AreEqual(HttpStatusCode.OK, result);
        }

        [TestMethod]
        public void TestDelete()
        {
            HttpStatusCode result = Class1.GetDelete();
            Assert.AreEqual(HttpStatusCode.OK, result);
        }
    }
}
