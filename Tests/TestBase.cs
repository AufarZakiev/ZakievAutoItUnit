using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using NUnit.Framework;

namespace ZakievAutoIt
{
    [TestFixture]
    class TestBase
    {
        protected AppManager appManager;
        [SetUp]
        public void SetupTest()
        {
            this.appManager = AppManager.GetAppmanagerInstance();
        }
    }
}
