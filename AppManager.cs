using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;

namespace ZakievAutoIt
{
    class AppManager
    {
        public ColourHelper colourHelper { get; }
        public DrawHelper drawHelper { get; }
        public FunctionsHelper functionsHelper { get; }
        public IntPtr winHandle { get; }
        private static AppManager instance;
        public float propX { get; }
        public float propY { get; }

        private AppManager()
        {
            AutoItX.Run("mspaint.exe", "C:\\WINDOWS\\system32");
            AutoItX.WinWaitActive("Безымянный");
            winHandle = AutoItX.WinGetHandle("Безымянный");

            /* 
             * Code for a greater good. Amen
             * */
            if (AutoItX.WinGetState(winHandle) < 32) // 32 - флаг неполностью развернутого окна
            {
                AutoItX.WinSetState(winHandle, AutoItX.SW_MAXIMIZE);
            }
            propX = AutoItX.WinGetClientSize(winHandle).Width / 1920f; // пропорции относительно экрана разработчика
            propY = AutoItX.WinGetClientSize(winHandle).Height / 875f;

            colourHelper = new ColourHelper(this);
            drawHelper = new DrawHelper(this);
            functionsHelper = new FunctionsHelper(this);
        }

        public static AppManager GetAppmanagerInstance()
        {
            if (instance == null)
            {
                instance = new AppManager();
            }
            return instance;
        }

        ~AppManager()
        {
            AutoItX.WinKill(winHandle);
        }
    }
}
