namespace DrawingClasses__Bakhtuev483_
{
    partial class DrawBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.figureList = new System.Windows.Forms.ComboBox();
            this.draw = new System.Windows.Forms.Button();
            this.figureText = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // figureList
            // 
            this.figureList.FormattingEnabled = true;
            this.figureList.Items.AddRange(new object[] {
            "circle",
            "square"});
            this.figureList.Location = new System.Drawing.Point(56, 6);
            this.figureList.Name = "figureList";
            this.figureList.Size = new System.Drawing.Size(111, 21);
            this.figureList.TabIndex = 0;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(173, 5);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 1;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // figureText
            // 
            this.figureText.AutoSize = true;
            this.figureText.Location = new System.Drawing.Point(12, 9);
            this.figureText.Name = "figureText";
            this.figureText.Size = new System.Drawing.Size(39, 13);
            this.figureText.TabIndex = 2;
            this.figureText.Text = "Figure:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(254, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.board.Location = new System.Drawing.Point(12, 34);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(622, 419);
            this.board.TabIndex = 6;
            this.board.TabStop = false;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint);
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.board_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            // 
            // DrawBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 465);
            this.Controls.Add(this.board);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.figureText);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.figureList);
            this.Name = "DrawBoard";
            this.Text = "Lab01 - Bakhtuev";
            this.Load += new System.EventHandler(this.DrawBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox figureList;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label figureText;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PictureBox board;
    }
}

