using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingClasses__Bakhtuev483_
{
    public class Figure
    {
        public float pos_x, pos_y; // Positions of mouse
        public bool selected; // Selected object

        virtual public bool test(float x, float y) // Inheritance class for checking params of object
        {
            return false;
        }

        virtual public void draw(Graphics g) // Inheritance class for drawing object
        {

        }
    }
}
