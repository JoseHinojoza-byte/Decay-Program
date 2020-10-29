namespace A2_Hinojoza
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
            this.txtTimeElapsed = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAmountInitial = new System.Windows.Forms.Label();
            this.lblAmountCurrent = new System.Windows.Forms.Label();
            this.txtAmountInitial = new System.Windows.Forms.TextBox();
            this.txtAmountCurrent = new System.Windows.Forms.TextBox();
            this.btnIncreaseTime = new System.Windows.Forms.Button();
            this.btnDecreaseTime = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHalfLifeCal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHalfLife = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimeElapsed
            // 
            this.txtTimeElapsed.Location = new System.Drawing.Point(155, 232);
            this.txtTimeElapsed.Name = "txtTimeElapsed";
            this.txtTimeElapsed.Size = new System.Drawing.Size(100, 20);
            this.txtTimeElapsed.TabIndex = 0;
            this.txtTimeElapsed.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(74, 235);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time Elapsed:";
            // 
            // lblAmountInitial
            // 
            this.lblAmountInitial.AutoSize = true;
            this.lblAmountInitial.Location = new System.Drawing.Point(75, 172);
            this.lblAmountInitial.Name = "lblAmountInitial";
            this.lblAmountInitial.Size = new System.Drawing.Size(73, 13);
            this.lblAmountInitial.TabIndex = 2;
            this.lblAmountInitial.Text = "Amount Initial:";
            // 
            // lblAmountCurrent
            // 
            this.lblAmountCurrent.AutoSize = true;
            this.lblAmountCurrent.Location = new System.Drawing.Point(65, 206);
            this.lblAmountCurrent.Name = "lblAmountCurrent";
            this.lblAmountCurrent.Size = new System.Drawing.Size(83, 13);
            this.lblAmountCurrent.TabIndex = 3;
            this.lblAmountCurrent.Text = "Amount Current:";
            // 
            // txtAmountInitial
            // 
            this.txtAmountInitial.Location = new System.Drawing.Point(155, 172);
            this.txtAmountInitial.Name = "txtAmountInitial";
            this.txtAmountInitial.Size = new System.Drawing.Size(100, 20);
            this.txtAmountInitial.TabIndex = 4;
            this.txtAmountInitial.Text = "0";
            // 
            // txtAmountCurrent
            // 
            this.txtAmountCurrent.Location = new System.Drawing.Point(155, 206);
            this.txtAmountCurrent.Name = "txtAmountCurrent";
            this.txtAmountCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCurrent.TabIndex = 5;
            this.txtAmountCurrent.Text = "0";
            // 
            // btnIncreaseTime
            // 
            this.btnIncreaseTime.Location = new System.Drawing.Point(300, 196);
            this.btnIncreaseTime.Name = "btnIncreaseTime";
            this.btnIncreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btnIncreaseTime.TabIndex = 6;
            this.btnIncreaseTime.Text = "Increase Time";
            this.btnIncreaseTime.UseVisualStyleBackColor = true;
            this.btnIncreaseTime.Click += new System.EventHandler(this.btnIncreaseTime_Click);
            // 
            // btnDecreaseTime
            // 
            this.btnDecreaseTime.Location = new System.Drawing.Point(300, 236);
            this.btnDecreaseTime.Name = "btnDecreaseTime";
            this.btnDecreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btnDecreaseTime.TabIndex = 7;
            this.btnDecreaseTime.Text = "Decrease Time";
            this.btnDecreaseTime.UseVisualStyleBackColor = true;
            this.btnDecreaseTime.Click += new System.EventHandler(this.btnDecreaseTime_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(307, 281);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHalfLifeCal
            // 
            this.btnHalfLifeCal.Location = new System.Drawing.Point(93, 281);
            this.btnHalfLifeCal.Name = "btnHalfLifeCal";
            this.btnHalfLifeCal.Size = new System.Drawing.Size(108, 23);
            this.btnHalfLifeCal.TabIndex = 9;
            this.btnHalfLifeCal.Text = "Calculate Half-Life";
            this.btnHalfLifeCal.UseVisualStyleBackColor = true;
            this.btnHalfLifeCal.Click += new System.EventHandler(this.btnHalfLifeCal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A2_Hinojoza.Properties.Resources.Gif2;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jose";
            // 
            // lblHalfLife
            // 
            this.lblHalfLife.AutoSize = true;
            this.lblHalfLife.Location = new System.Drawing.Point(68, 340);
            this.lblHalfLife.Name = "lblHalfLife";
            this.lblHalfLife.Size = new System.Drawing.Size(0, 13);
            this.lblHalfLife.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 379);
            this.Controls.Add(this.lblHalfLife);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHalfLifeCal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecreaseTime);
            this.Controls.Add(this.btnIncreaseTime);
            this.Controls.Add(this.txtAmountCurrent);
            this.Controls.Add(this.txtAmountInitial);
            this.Controls.Add(this.lblAmountCurrent);
            this.Controls.Add(this.lblAmountInitial);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTimeElapsed);
            this.Name = "Form1";
            this.Text = "Assignement2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimeElapsed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAmountInitial;
        private System.Windows.Forms.Label lblAmountCurrent;
        private System.Windows.Forms.TextBox txtAmountInitial;
        private System.Windows.Forms.TextBox txtAmountCurrent;
        private System.Windows.Forms.Button btnIncreaseTime;
        private System.Windows.Forms.Button btnDecreaseTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHalfLifeCal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHalfLife;
    }
}

