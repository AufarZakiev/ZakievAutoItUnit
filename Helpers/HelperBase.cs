using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using NUnit.Framework;

namespace ZakievAutoIt
{
    class HelperBase
    {
        protected AppManager appManager;
        public HelperBase(AppManager appManager) {
            this.appManager = appManager;
        }
    }
}
