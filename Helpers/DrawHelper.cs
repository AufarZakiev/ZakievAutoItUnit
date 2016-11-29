using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;

namespace ZakievAutoIt
{
    class DrawHelper:HelperBase
    {
        const int MAIN_TOP_PANEL_HEIGHT = 147; // фиксированная высота меню инструментов в Paint при любом разрешении экрана

        public DrawHelper(AppManager appManager) : base(appManager){
           
        }

        public void DrawLine(int xStartCoordinate, int yStartCoordinate, int xEndCoordinate, int yEndCoordinate)
        {
            AutoItX.MouseClickDrag("LEFT", xCoordinateRefactor(xStartCoordinate), yCoordianteRefactor(yStartCoordinate), xCoordinateRefactor(xEndCoordinate), yCoordianteRefactor(yEndCoordinate));
        }

        private int xCoordinateRefactor(int xCoordinate)
        {
            return (int)(xCoordinate * appManager.propX);
        }

        private int yCoordianteRefactor(int yCoordinate)
        {
            return (int)((yCoordinate -MAIN_TOP_PANEL_HEIGHT) * appManager.propY) + MAIN_TOP_PANEL_HEIGHT;
        }
    }
}
