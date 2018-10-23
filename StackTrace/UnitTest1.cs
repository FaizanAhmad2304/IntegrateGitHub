using System;
using ClassLibrary3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackTrace
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFail1()
        {
            Level1 cls = new Level1();

            cls.SumOfCube(2, 3);
        }

        [TestMethod]
        public void TestMethodFail2()
        {
            try
            {
                Level1 cls = new Level1();
                cls.SumOfCube(2, 3);
            }
            catch (Exception ex)
            {
                throw new Exception("Test level", ex);
            }

        }

        [TestMethod]
        public void TestMethodPass1()
        {

        }

        [TestMethod]
        public void TestMethodPass2()
        {

        }
        
        [TestMethod]
        public void TestMethodPass3()
        {

        }

    }
}
