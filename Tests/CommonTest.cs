using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using NUnit.Framework;

namespace ZakievAutoIt
{
    class CommonTest : TestBase
    {
        [Test]
        public void ExampleCommonTest()
        {
            appManager.colourHelper.ChangePrimaryColour("Brown");
            appManager.drawHelper.DrawLine(800, 200, 981, 280);
            appManager.functionsHelper.Save("C:\\Download", "testsave.png");

            Assert.That(AutoItX.WinGetTitle(), Is.EqualTo("testsave.png - Paint"));
        }

    }
}
