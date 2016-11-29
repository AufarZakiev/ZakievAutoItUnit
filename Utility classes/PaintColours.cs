using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakievAutoIt
{
    class PaintColours
    { 
        static private PaintColours instance;
        private List<Colour> list;

        private PaintColours() {
            list = new List<Colour>();
        }

        public static PaintColours GetPaintColoursInstance() {
            if (instance == null)
            {
                instance = new PaintColours();
                instance.AddNewColour(1065, 60, "Indigo");
                instance.AddNewColour(980, 65, "Orange");
                instance.AddNewColour(930, 85, "Brown");
            }
            return instance;
        }

        public void AddNewColour(int x,int y,string colourName) {
            list.Add(new Colour(x, y, colourName));
        }

        public Colour GetColourByName(string name) 
        {
            return list.Find(x => x.name == name);
        }
    }
}
