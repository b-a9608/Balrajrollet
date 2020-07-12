using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roullete;

namespace Russian_Roullete_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game gm = new Game();
            gm.spinner(2);
            if(gm.Awayshoot()>1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void form2Test()
        {
            Game gm = new Game();
            int sppinner = gm.spinner(2);
            if (sppinner == 3)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
