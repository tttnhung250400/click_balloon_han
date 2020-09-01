namespace Midterm_Clickballoon
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbDiem);
            this.panel1.Location = new System.Drawing.Point(849, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 322);
            this.panel1.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(61, 131);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(234, 78);
            this.lb1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retry";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbDiem.Location = new System.Drawing.Point(13, 27);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(183, 63);
            this.lbDiem.TabIndex = 0;
            this.lbDiem.Text = "Score:";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameEngine);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Midterm_Clickballoon.Properties.Resources.boom;
            this.pictureBox1.Location = new System.Drawing.Point(588, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "bomb";
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.popBomb);
            // 
            // bomb
            // 
            this.bomb.Image = global::Midterm_Clickballoon.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(931, 408);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(119, 148);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 0;
            this.bomb.TabStop = false;
            this.bomb.Tag = "bomb";
            this.bomb.Click += new System.EventHandler(this.popBomb);
            // 
            // pic4
            // 
            this.pic4.Image = global::Midterm_Clickballoon.Properties.Resources.yellowBalloon;
            this.pic4.Location = new System.Drawing.Point(717, 408);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(124, 148);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 0;
            this.pic4.TabStop = false;
            this.pic4.Tag = "Balloon";
            this.pic4.Click += new System.EventHandler(this.pop_Balloon);
            // 
            // pic3
            // 
            this.pic3.Image = global::Midterm_Clickballoon.Properties.Resources.pinkBalloon;
            this.pic3.Location = new System.Drawing.Point(469, 403);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(134, 153);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 0;
            this.pic3.TabStop = false;
            this.pic3.Tag = "Balloon";
            this.pic3.Click += new System.EventHandler(this.pop_Balloon);
            // 
            // pic2
            // 
            this.pic2.Image = global::Midterm_Clickballoon.Properties.Resources.redStar;
            this.pic2.Location = new System.Drawing.Point(279, 403);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(113, 153);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            this.pic2.Tag = "Balloon";
            this.pic2.Click += new System.EventHandler(this.pop_Balloon);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(65, 403);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(136, 153);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Tag = "Balloon";
            this.pic1.Click += new System.EventHandler(this.pop_Balloon);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1249, 1109);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.MaximumSize = new System.Drawing.Size(1277, 1188);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}