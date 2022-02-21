using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingClasses__Bakhtuev483_
{
    class Circle : Figure // Inheritance class
    {
        public float radius; // Radius

        public Circle()
        {
            radius = 50.0f; // Set float
        }

        public override bool test(float x, float y) // Check conditions
        {
            float radius_squared = radius * radius; // Radius for check circle params
            float dx = x - pos_x; // Point x of 
            float dy = y - pos_y; // Point y of

            if (dx + dx + dy + dy <= radius_squared) // Condition
            {
                return true; // Accept (re) drawing
            }

            return false; // Reject
        }

        public override void draw (Graphics g) // Drawing object
        {
            float diameter = radius * 2.0f;
            float x0 = pos_x - radius; // Where: pos_x = 1st position of mouse
            float y0 = pos_y - radius; // Where: pos_x = 2nd position of mouse

            Pen pen = Pens.Black; // Creating new pen with color

            if (selected == true) // Check selecting
            {
                pen = Pens.Red; // Redraw circuit to red
            }

            g.DrawEllipse(pen, x0, y0, diameter, diameter); // Complete first draw or changes
        }

    }
}
