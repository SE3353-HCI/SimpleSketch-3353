namespace SimpleSketch_3353
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CursorButton = new System.Windows.Forms.Button();
            this.YellowColor = new System.Windows.Forms.Button();
            this.BlackColor = new System.Windows.Forms.Button();
            this.PurpleColor = new System.Windows.Forms.Button();
            this.BlueColor = new System.Windows.Forms.Button();
            this.GreenColor = new System.Windows.Forms.Button();
            this.RedColor = new System.Windows.Forms.Button();
            this.freeHand = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.Location = new System.Drawing.Point(12, 111);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(50, 45);
            this.line.TabIndex = 0;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(12, 213);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(50, 45);
            this.rectangle.TabIndex = 1;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.Location = new System.Drawing.Point(12, 162);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(50, 45);
            this.ellipse.TabIndex = 2;
            this.ellipse.Text = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CursorButton);
            this.panel1.Controls.Add(this.YellowColor);
            this.panel1.Controls.Add(this.BlackColor);
            this.panel1.Controls.Add(this.PurpleColor);
            this.panel1.Controls.Add(this.BlueColor);
            this.panel1.Controls.Add(this.GreenColor);
            this.panel1.Controls.Add(this.RedColor);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.ellipse);
            this.panel1.Controls.Add(this.freeHand);
            this.panel1.Controls.Add(this.line);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 415);
            this.panel1.TabIndex = 3;
            // 
            // CursorButton
            // 
            this.CursorButton.Location = new System.Drawing.Point(12, 9);
            this.CursorButton.Name = "CursorButton";
            this.CursorButton.Size = new System.Drawing.Size(50, 45);
            this.CursorButton.TabIndex = 10;
            this.CursorButton.Text = "Cursor";
            this.CursorButton.UseVisualStyleBackColor = true;
            this.CursorButton.Click += new System.EventHandler(this.CursorButton_Click);
            // 
            // YellowColor
            // 
            this.YellowColor.BackColor = System.Drawing.Color.Yellow;
            this.YellowColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowColor.Location = new System.Drawing.Point(38, 329);
            this.YellowColor.Name = "YellowColor";
            this.YellowColor.Size = new System.Drawing.Size(25, 25);
            this.YellowColor.TabIndex = 9;
            this.YellowColor.UseVisualStyleBackColor = false;
            this.YellowColor.Click += new System.EventHandler(this.YellowColor_Click);
            // 
            // BlackColor
            // 
            this.BlackColor.BackColor = System.Drawing.Color.Black;
            this.BlackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlackColor.Location = new System.Drawing.Point(7, 329);
            this.BlackColor.Name = "BlackColor";
            this.BlackColor.Size = new System.Drawing.Size(25, 25);
            this.BlackColor.TabIndex = 8;
            this.BlackColor.UseVisualStyleBackColor = false;
            this.BlackColor.Click += new System.EventHandler(this.BlackColor_Click);
            // 
            // PurpleColor
            // 
            this.PurpleColor.BackColor = System.Drawing.Color.Purple;
            this.PurpleColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurpleColor.Location = new System.Drawing.Point(38, 297);
            this.PurpleColor.Name = "PurpleColor";
            this.PurpleColor.Size = new System.Drawing.Size(25, 25);
            this.PurpleColor.TabIndex = 7;
            this.PurpleColor.UseVisualStyleBackColor = false;
            this.PurpleColor.Click += new System.EventHandler(this.PurpleColor_Click);
            // 
            // BlueColor
            // 
            this.BlueColor.BackColor = System.Drawing.Color.Blue;
            this.BlueColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueColor.Location = new System.Drawing.Point(6, 297);
            this.BlueColor.Name = "BlueColor";
            this.BlueColor.Size = new System.Drawing.Size(25, 25);
            this.BlueColor.TabIndex = 6;
            this.BlueColor.UseVisualStyleBackColor = false;
            this.BlueColor.Click += new System.EventHandler(this.BlueColor_Click);
            // 
            // GreenColor
            // 
            this.GreenColor.BackColor = System.Drawing.Color.Green;
            this.GreenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenColor.Location = new System.Drawing.Point(38, 265);
            this.GreenColor.Name = "GreenColor";
            this.GreenColor.Size = new System.Drawing.Size(25, 25);
            this.GreenColor.TabIndex = 5;
            this.GreenColor.UseVisualStyleBackColor = false;
            this.GreenColor.Click += new System.EventHandler(this.GreenColor_Click);
            // 
            // RedColor
            // 
            this.RedColor.BackColor = System.Drawing.Color.Red;
            this.RedColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedColor.ForeColor = System.Drawing.Color.Red;
            this.RedColor.Location = new System.Drawing.Point(6, 265);
            this.RedColor.Name = "RedColor";
            this.RedColor.Size = new System.Drawing.Size(25, 25);
            this.RedColor.TabIndex = 4;
            this.RedColor.UseVisualStyleBackColor = false;
            this.RedColor.Click += new System.EventHandler(this.RedColor_Click);
            // 
            // freeHand
            // 
            this.freeHand.Location = new System.Drawing.Point(12, 60);
            this.freeHand.Name = "freeHand";
            this.freeHand.Size = new System.Drawing.Size(50, 45);
            this.freeHand.TabIndex = 3;
            this.freeHand.Text = "Free Hand";
            this.freeHand.UseVisualStyleBackColor = true;
            this.freeHand.Click += new System.EventHandler(this.freeHand_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(84, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 502);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(701, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(96, 350);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 538);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button freeHand;
        private System.Windows.Forms.Button GreenColor;
        private System.Windows.Forms.Button RedColor;
        private System.Windows.Forms.Button BlueColor;
        private System.Windows.Forms.Button PurpleColor;
        private System.Windows.Forms.Button BlackColor;
        private System.Windows.Forms.Button YellowColor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button CursorButton;
    }
}

