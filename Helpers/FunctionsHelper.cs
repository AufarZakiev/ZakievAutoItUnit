using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;

namespace ZakievAutoIt
{
    class FunctionsHelper:HelperBase
    {
        public FunctionsHelper(AppManager appManager) : base(appManager) {

        }

        public void Save(string path, string filename) {
            AutoItX.MouseClick("LEFT", 20, 30, 1); //клик по "Файл"
            AutoItX.MouseClick("LEFT", 42, 213, 1); //клик по "Сохранить как"
            AutoItX.MouseClick("LEFT", 515, 80, 1); //клик по "Сохранить как PNG"
            AutoItX.Sleep(1000);
            AutoItX.WinWaitActive("Сохранение");
            AutoItX.Send(filename);
            AutoItX.Sleep(1000);
            AutoItX.ControlClick("Сохранение", "", "ToolbarWindow324"); //выделение контрола пути
            AutoItX.Send(path+"{ENTER}"); //набор пути и клац о клавишу Enter
            AutoItX.ControlClick("Сохранение", "", "Button2"); //клик по кнопке "сохранить"
            AutoItX.WinWaitActive(filename);
        }
    }
}
