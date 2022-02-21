using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingClasses__Bakhtuev483_
{
    public partial class DrawBoard : Form
    {
        public DrawBoard()
        {
            InitializeComponent();
        }

        int old_x, old_y; // Default (old) position of object

        List<Figure> list = new List<Figure>(); // List of figures

        Figure createFigure(string fig_type) // Drawing selected figure from ComboBox
        {
            switch (fig_type)
            {
                case "circle": return new Circle(); // Creating new Cirlce (start executing class)
                case "square": return new Square(); // Creating new Square (start executing class)
            }
            return null;
        }

        private void DrawBoard_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e) // Delete selected figure
        {
            int i = 0; // Param for cycle

            while (i < list.Count) // Cycle
            {
                if (list[i].selected == true) // Checking object on selected status
                {
                    list.RemoveAt(i); // Deleting selected object
                }
                i++; // Checking next figure
            }
            board.Invalidate(); // Validating drawing board
        }

        private void draw_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(figureList.Text); // Creaing new figure

            if (fig == null) // Condition to exist figure
            {
                return; // Failed
            }

            fig.pos_x = 100.0f; // Setting x param
            fig.pos_y = 100.0f; // Setting y param

            list.Add(fig); // Add figure to list
            board.Invalidate(); // Validating drawing board
        }

        private void board_Paint(object sender, PaintEventArgs e) // Painting
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, board.Width, board.Height); // Filling figure with color

            foreach (Figure fig in list) // for each figure
            {
                fig.draw(e.Graphics); // Completing operation
            }
        }

        private void board_MouseDown(object sender, MouseEventArgs e) // Where user stop keeping left mouse button
        {
            foreach (Figure fig in list) // For each figure
            {
                fig.selected = false; // Set select param
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Figure fig = list[i]; // List of figures
                fig.selected |= fig.test(e.X, e.Y); // Checking params

                if (fig.selected == true) // Check condition of selecting figure
                {
                    break; // Breaking execute (exit)
                }
            }

            board.Invalidate(); // Validating drawing board
        }

        private void board_MouseMove(object sender, MouseEventArgs e) // Where user moving object with pressed left mouse button
        {
            if (e.Button == MouseButtons.Left) // Condition
            {
                int dx = e.X - old_x; // Calculation of rendering x point
                int dy = e.Y - old_y; // Calculation of rendering y point

                foreach (Figure fig in list) // For each figure
                {
                    if (fig.selected == false) // Check condition of selecting figure
                    {
                        continue; // Condition completed, continue executing code
                    }
                        
                    fig.pos_x += dx; // Updating x position
                    fig.pos_y += dy; // Updating y position
                }

                board.Invalidate(); // Validating drawing board
            }

            old_x = e.X;  // Updating x position
            old_y = e.Y;  // Updating y position
        }
    }
}
