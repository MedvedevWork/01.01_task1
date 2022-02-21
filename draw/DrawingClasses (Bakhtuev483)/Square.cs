using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingClasses__Bakhtuev483_
{
    class Square : Figure // Inheritance class
    {
        public float side; // Side of square

        public Square()
        {
            side = 100;
        }

        public override bool test(float x, float y) // Check conditions
        {
            float half_side = side * 0.5f; // Using for check conditions
            float xmin = pos_x - half_side; // Min x condition value
            float ymin = pos_y - half_side; // Min y condition value
            float xmax = pos_x + half_side; // Max x condition value
            float ymax = pos_y + half_side; // Max y condition value

            if (x < xmin || y < ymin) // Check min conditions
            {
                return false; // Reject drawing
            }

            if ( x > xmax || y > ymax) // Check max conditions
            {
                return false; // Reject drawing
            }

            return true; // Accept drawing
        }

        public override void draw (Graphics g) // Drawing object
        {
            float half_side = side * 0.5f; // Using for set params of drawing object
            float x0 = pos_x - half_side; // First point 
            float y0 = pos_y - half_side; // Second point

            Pen pen = Pens.Black; // Creating new pen with color

            if (selected == true) // Check selecting
            {
                pen = Pens.Red; // Redraw circuit to red
            }

            g.DrawRectangle(pen, x0, y0, side, side); // Complete first draw or changes
        }
    }
}
