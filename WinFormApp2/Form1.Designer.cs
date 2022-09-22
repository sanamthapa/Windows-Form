namespace WinFormApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button6;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTACTUSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.Color.Transparent;
            button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(357, 22);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(169, 58);
            button3.TabIndex = 2;
            button3.Text = "Add Items";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.ForeColor = System.Drawing.Color.Transparent;
            button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Location = new System.Drawing.Point(556, 22);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(141, 58);
            button4.TabIndex = 3;
            button4.Text = "Products";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.ForeColor = System.Drawing.Color.Transparent;
            button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.Location = new System.Drawing.Point(716, 22);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(141, 58);
            button5.TabIndex = 4;
            button5.Text = "Reports ";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.ForeColor = System.Drawing.Color.Transparent;
            button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button6.Location = new System.Drawing.Point(879, 22);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(141, 58);
            button6.TabIndex = 5;
            button6.Text = "Shop";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(button6);
            this.panel1.Controls.Add(button5);
            this.panel1.Controls.Add(button4);
            this.panel1.Controls.Add(button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 104);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(208, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Invoice";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(21, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registration";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 655);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.cONTACTUSToolStripMenuItem1,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.homeToolStripMenuItem.Text = "HOME";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.servicesToolStripMenuItem.Text = "ABOUT US";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.contactUsToolStripMenuItem.Text = "SERVICES";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // cONTACTUSToolStripMenuItem1
            // 
            this.cONTACTUSToolStripMenuItem1.Name = "cONTACTUSToolStripMenuItem1";
            this.cONTACTUSToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.cONTACTUSToolStripMenuItem1.Text = "CONTACT US";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem contactUsToolStripMenuItem;
        private ToolStripMenuItem cONTACTUSToolStripMenuItem1;
        private ToolStripMenuItem eXITToolStripMenuItem;
    }
}