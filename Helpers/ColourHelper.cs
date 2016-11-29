using AutoIt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakievAutoIt
{
    class ColourHelper : HelperBase
    {
        PaintColours pc;
        public ColourHelper(AppManager appManager) : base(appManager)
        {
            pc = PaintColours.GetPaintColoursInstance();
        }

        public void ChangePrimaryColour(string colourName) { 
            Colour chosenColour = pc.GetColourByName(colourName);
            AutoItX.MouseClick("LEFT", chosenColour.x, chosenColour.y);
        }
    }
}
