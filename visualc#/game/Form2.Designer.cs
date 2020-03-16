namespace game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mario_right = new System.Windows.Forms.ImageList(this.components);
            this.mario_left = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mario_right_stand = new System.Windows.Forms.ImageList(this.components);
            this.mario_left_stand = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toxic_flower = new System.Windows.Forms.ImageList(this.components);
            this.toxic_pond = new System.Windows.Forms.ImageList(this.components);
            this.toxic_mush_right = new System.Windows.Forms.ImageList(this.components);
            this.toxic_mush_left = new System.Windows.Forms.ImageList(this.components);
            this.toxic_turtle = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.freeFall = new System.Windows.Forms.Timer(this.components);
            this.mario_motion = new System.Windows.Forms.Timer(this.components);
            this.mario_right_die = new System.Windows.Forms.ImageList(this.components);
            this.mario_left_die = new System.Windows.Forms.ImageList(this.components);
            this.mario_die = new System.Windows.Forms.Timer(this.components);
            this.coin = new System.Windows.Forms.ImageList(this.components);
            this.toxic_mush_dead = new System.Windows.Forms.ImageList(this.components);
            this.toxic_fish_dead = new System.Windows.Forms.ImageList(this.components);
            this.toxic_turtle_dead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::game.Properties.Resources.clock3;
            this.pictureBox1.Location = new System.Drawing.Point(1236, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mario_right
            // 
            this.mario_right.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_right.ImageStream")));
            this.mario_right.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_right.Images.SetKeyName(0, "1.png");
            this.mario_right.Images.SetKeyName(1, "2.png");
            this.mario_right.Images.SetKeyName(2, "3.png");
            this.mario_right.Images.SetKeyName(3, "2.png");
            // 
            // mario_left
            // 
            this.mario_left.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_left.ImageStream")));
            this.mario_left.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_left.Images.SetKeyName(0, "1.png");
            this.mario_left.Images.SetKeyName(1, "2.png");
            this.mario_left.Images.SetKeyName(2, "3.png");
            this.mario_left.Images.SetKeyName(3, "2.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::game.Properties.Resources.coin_cnt3;
            this.pictureBox2.Image = global::game.Properties.Resources.coin_cnt3;
            this.pictureBox2.Location = new System.Drawing.Point(43, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 58);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mario_right_stand
            // 
            this.mario_right_stand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_right_stand.ImageStream")));
            this.mario_right_stand.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_right_stand.Images.SetKeyName(0, "1.png");
            this.mario_right_stand.Images.SetKeyName(1, "2.png");
            // 
            // mario_left_stand
            // 
            this.mario_left_stand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_left_stand.ImageStream")));
            this.mario_left_stand.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_left_stand.Images.SetKeyName(0, "1.png");
            this.mario_left_stand.Images.SetKeyName(1, "2.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // toxic_flower
            // 
            this.toxic_flower.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_flower.ImageStream")));
            this.toxic_flower.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_flower.Images.SetKeyName(0, "1.png");
            this.toxic_flower.Images.SetKeyName(1, "2.png");
            this.toxic_flower.Images.SetKeyName(2, "3.png");
            this.toxic_flower.Images.SetKeyName(3, "4.png");
            this.toxic_flower.Images.SetKeyName(4, "5.png");
            this.toxic_flower.Images.SetKeyName(5, "6.png");
            this.toxic_flower.Images.SetKeyName(6, "7.png");
            this.toxic_flower.Images.SetKeyName(7, "8.png");
            this.toxic_flower.Images.SetKeyName(8, "9.png");
            // 
            // toxic_pond
            // 
            this.toxic_pond.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_pond.ImageStream")));
            this.toxic_pond.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_pond.Images.SetKeyName(0, "p.png");
            this.toxic_pond.Images.SetKeyName(1, "pond2.png");
            // 
            // toxic_mush_right
            // 
            this.toxic_mush_right.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_mush_right.ImageStream")));
            this.toxic_mush_right.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_mush_right.Images.SetKeyName(0, "1.png");
            this.toxic_mush_right.Images.SetKeyName(1, "2.png");
            // 
            // toxic_mush_left
            // 
            this.toxic_mush_left.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_mush_left.ImageStream")));
            this.toxic_mush_left.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_mush_left.Images.SetKeyName(0, "1.png");
            this.toxic_mush_left.Images.SetKeyName(1, "2.png");
            // 
            // toxic_turtle
            // 
            this.toxic_turtle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_turtle.ImageStream")));
            this.toxic_turtle.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_turtle.Images.SetKeyName(0, "1.png");
            this.toxic_turtle.Images.SetKeyName(1, "2.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // freeFall
            // 
            this.freeFall.Interval = 10;
            this.freeFall.Tick += new System.EventHandler(this.freeFall_Tick);
            // 
            // mario_motion
            // 
            this.mario_motion.Enabled = true;
            this.mario_motion.Interval = 1;
            this.mario_motion.Tick += new System.EventHandler(this.mario_motion_Tick);
            // 
            // mario_right_die
            // 
            this.mario_right_die.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_right_die.ImageStream")));
            this.mario_right_die.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_right_die.Images.SetKeyName(0, "1.png");
            this.mario_right_die.Images.SetKeyName(1, "2.png");
            // 
            // mario_left_die
            // 
            this.mario_left_die.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mario_left_die.ImageStream")));
            this.mario_left_die.TransparentColor = System.Drawing.Color.Transparent;
            this.mario_left_die.Images.SetKeyName(0, "1.png");
            this.mario_left_die.Images.SetKeyName(1, "2.png");
            // 
            // mario_die
            // 
            this.mario_die.Interval = 10;
            this.mario_die.Tick += new System.EventHandler(this.mario_die_Tick);
            // 
            // coin
            // 
            this.coin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("coin.ImageStream")));
            this.coin.TransparentColor = System.Drawing.Color.Transparent;
            this.coin.Images.SetKeyName(0, "1.png");
            this.coin.Images.SetKeyName(1, "3.png");
            this.coin.Images.SetKeyName(2, "5.png");
            this.coin.Images.SetKeyName(3, "6.png");
            this.coin.Images.SetKeyName(4, "5.png");
            this.coin.Images.SetKeyName(5, "3.png");
            // 
            // toxic_mush_dead
            // 
            this.toxic_mush_dead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_mush_dead.ImageStream")));
            this.toxic_mush_dead.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_mush_dead.Images.SetKeyName(0, "2.png");
            this.toxic_mush_dead.Images.SetKeyName(1, "4.png");
            this.toxic_mush_dead.Images.SetKeyName(2, "6.png");
            this.toxic_mush_dead.Images.SetKeyName(3, "4.png");
            // 
            // toxic_fish_dead
            // 
            this.toxic_fish_dead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_fish_dead.ImageStream")));
            this.toxic_fish_dead.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_fish_dead.Images.SetKeyName(0, "5.png");
            this.toxic_fish_dead.Images.SetKeyName(1, "6.png");
            this.toxic_fish_dead.Images.SetKeyName(2, "2.png");
            this.toxic_fish_dead.Images.SetKeyName(3, "6.png");
            // 
            // toxic_turtle_dead
            // 
            this.toxic_turtle_dead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toxic_turtle_dead.ImageStream")));
            this.toxic_turtle_dead.TransparentColor = System.Drawing.Color.Transparent;
            this.toxic_turtle_dead.Images.SetKeyName(0, "1.png");
            this.toxic_turtle_dead.Images.SetKeyName(1, "3.png");
            this.toxic_turtle_dead.Images.SetKeyName(2, "4.png");
            this.toxic_turtle_dead.Images.SetKeyName(3, "5.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::game.Properties.Resources.bk21;
            this.ClientSize = new System.Drawing.Size(1579, 889);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList mario_right;
        private System.Windows.Forms.ImageList mario_left;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList mario_right_stand;
        private System.Windows.Forms.ImageList mario_left_stand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList toxic_flower;
        private System.Windows.Forms.ImageList toxic_pond;
        private System.Windows.Forms.ImageList toxic_mush_right;
        private System.Windows.Forms.ImageList toxic_mush_left;
        private System.Windows.Forms.ImageList toxic_turtle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer freeFall;
        private System.Windows.Forms.Timer mario_motion;
        private System.Windows.Forms.ImageList mario_right_die;
        private System.Windows.Forms.ImageList mario_left_die;
        private System.Windows.Forms.Timer mario_die;
        private System.Windows.Forms.ImageList coin;
        private System.Windows.Forms.ImageList toxic_mush_dead;
        private System.Windows.Forms.ImageList toxic_fish_dead;
        private System.Windows.Forms.ImageList toxic_turtle_dead;
    }
}