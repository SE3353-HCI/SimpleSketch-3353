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
            this.circle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
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
            this.polygon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // line
            // 
            resources.ApplyResources(this.line, "line");
            this.line.Name = "line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            resources.ApplyResources(this.rectangle, "rectangle");
            this.rectangle.Name = "rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            resources.ApplyResources(this.ellipse, "ellipse");
            this.ellipse.Name = "ellipse";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.polygon);
            this.panel1.Controls.Add(this.circle);
            this.panel1.Controls.Add(this.square);
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // circle
            // 
            resources.ApplyResources(this.circle, "circle");
            this.circle.Name = "circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // square
            // 
            resources.ApplyResources(this.square, "square");
            this.square.Name = "square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // CursorButton
            // 
            resources.ApplyResources(this.CursorButton, "CursorButton");
            this.CursorButton.Name = "CursorButton";
            this.CursorButton.UseVisualStyleBackColor = true;
            this.CursorButton.Click += new System.EventHandler(this.CursorButton_Click);
            // 
            // YellowColor
            // 
            this.YellowColor.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.YellowColor, "YellowColor");
            this.YellowColor.Name = "YellowColor";
            this.YellowColor.UseVisualStyleBackColor = false;
            this.YellowColor.Click += new System.EventHandler(this.YellowColor_Click);
            // 
            // BlackColor
            // 
            this.BlackColor.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.BlackColor, "BlackColor");
            this.BlackColor.Name = "BlackColor";
            this.BlackColor.UseVisualStyleBackColor = false;
            this.BlackColor.Click += new System.EventHandler(this.BlackColor_Click);
            // 
            // PurpleColor
            // 
            this.PurpleColor.BackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.PurpleColor, "PurpleColor");
            this.PurpleColor.Name = "PurpleColor";
            this.PurpleColor.UseVisualStyleBackColor = false;
            this.PurpleColor.Click += new System.EventHandler(this.PurpleColor_Click);
            // 
            // BlueColor
            // 
            this.BlueColor.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.BlueColor, "BlueColor");
            this.BlueColor.Name = "BlueColor";
            this.BlueColor.UseVisualStyleBackColor = false;
            this.BlueColor.Click += new System.EventHandler(this.BlueColor_Click);
            // 
            // GreenColor
            // 
            this.GreenColor.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.GreenColor, "GreenColor");
            this.GreenColor.Name = "GreenColor";
            this.GreenColor.UseVisualStyleBackColor = false;
            this.GreenColor.Click += new System.EventHandler(this.GreenColor_Click);
            // 
            // RedColor
            // 
            this.RedColor.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.RedColor, "RedColor");
            this.RedColor.ForeColor = System.Drawing.Color.Red;
            this.RedColor.Name = "RedColor";
            this.RedColor.UseVisualStyleBackColor = false;
            this.RedColor.Click += new System.EventHandler(this.RedColor_Click);
            // 
            // freeHand
            // 
            resources.ApplyResources(this.freeHand, "freeHand");
            this.freeHand.Name = "freeHand";
            this.freeHand.UseVisualStyleBackColor = true;
            this.freeHand.Click += new System.EventHandler(this.freeHand_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // polygon
            // 
            resources.ApplyResources(this.polygon, "polygon");
            this.polygon.Name = "polygon";
            this.polygon.UseVisualStyleBackColor = true;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button polygon;
    }
}

