namespace DigitalClock
{
    partial class digitalClock
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
            this.lblClock = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redbtn = new System.Windows.Forms.Button();
            this.orangebtn = new System.Windows.Forms.Button();
            this.yellowbtn = new System.Windows.Forms.Button();
            this.greenbtn = new System.Windows.Forms.Button();
            this.cyanbtn = new System.Windows.Forms.Button();
            this.stylebtn = new System.Windows.Forms.Button();
            this.stylebtn2 = new System.Windows.Forms.Button();
            this.stylebtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Red;
            this.lblClock.Location = new System.Drawing.Point(12, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(776, 432);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "Loading...";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redbtn
            // 
            this.redbtn.BackColor = System.Drawing.Color.Red;
            this.redbtn.Location = new System.Drawing.Point(10, 451);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(21, 25);
            this.redbtn.TabIndex = 1;
            this.redbtn.UseVisualStyleBackColor = false;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // orangebtn
            // 
            this.orangebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangebtn.Location = new System.Drawing.Point(37, 451);
            this.orangebtn.Name = "orangebtn";
            this.orangebtn.Size = new System.Drawing.Size(21, 25);
            this.orangebtn.TabIndex = 1;
            this.orangebtn.UseVisualStyleBackColor = false;
            this.orangebtn.Click += new System.EventHandler(this.orangebtn_Click);
            // 
            // yellowbtn
            // 
            this.yellowbtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowbtn.Location = new System.Drawing.Point(64, 451);
            this.yellowbtn.Name = "yellowbtn";
            this.yellowbtn.Size = new System.Drawing.Size(21, 25);
            this.yellowbtn.TabIndex = 1;
            this.yellowbtn.UseVisualStyleBackColor = false;
            this.yellowbtn.Click += new System.EventHandler(this.yellowbtn_Click);
            // 
            // greenbtn
            // 
            this.greenbtn.BackColor = System.Drawing.Color.Green;
            this.greenbtn.Location = new System.Drawing.Point(91, 451);
            this.greenbtn.Name = "greenbtn";
            this.greenbtn.Size = new System.Drawing.Size(21, 25);
            this.greenbtn.TabIndex = 1;
            this.greenbtn.UseVisualStyleBackColor = false;
            this.greenbtn.Click += new System.EventHandler(this.greenbtn_Click);
            // 
            // cyanbtn
            // 
            this.cyanbtn.BackColor = System.Drawing.Color.Cyan;
            this.cyanbtn.Location = new System.Drawing.Point(118, 451);
            this.cyanbtn.Name = "cyanbtn";
            this.cyanbtn.Size = new System.Drawing.Size(21, 25);
            this.cyanbtn.TabIndex = 1;
            this.cyanbtn.UseVisualStyleBackColor = false;
            this.cyanbtn.Click += new System.EventHandler(this.cyanbtn_Click);
            // 
            // stylebtn
            // 
            this.stylebtn.BackColor = System.Drawing.Color.White;
            this.stylebtn.Font = new System.Drawing.Font("Impact", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylebtn.Location = new System.Drawing.Point(145, 444);
            this.stylebtn.Name = "stylebtn";
            this.stylebtn.Size = new System.Drawing.Size(75, 33);
            this.stylebtn.TabIndex = 2;
            this.stylebtn.Text = "Style 1";
            this.stylebtn.UseVisualStyleBackColor = false;
            this.stylebtn.Click += new System.EventHandler(this.stylebtn_Click);
            // 
            // stylebtn2
            // 
            this.stylebtn2.BackColor = System.Drawing.Color.White;
            this.stylebtn2.Font = new System.Drawing.Font("Lucida Handwriting", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylebtn2.Location = new System.Drawing.Point(226, 444);
            this.stylebtn2.Name = "stylebtn2";
            this.stylebtn2.Size = new System.Drawing.Size(75, 32);
            this.stylebtn2.TabIndex = 2;
            this.stylebtn2.Text = "Style 2";
            this.stylebtn2.UseVisualStyleBackColor = false;
            this.stylebtn2.Click += new System.EventHandler(this.stylebtn2_Click);
            // 
            // stylebtn3
            // 
            this.stylebtn3.BackColor = System.Drawing.Color.White;
            this.stylebtn3.Font = new System.Drawing.Font("Algerian", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylebtn3.Location = new System.Drawing.Point(307, 444);
            this.stylebtn3.Name = "stylebtn3";
            this.stylebtn3.Size = new System.Drawing.Size(75, 32);
            this.stylebtn3.TabIndex = 2;
            this.stylebtn3.Text = "Style 3";
            this.stylebtn3.UseVisualStyleBackColor = false;
            this.stylebtn3.Click += new System.EventHandler(this.stylebtn3_Click);
            // 
            // digitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.stylebtn3);
            this.Controls.Add(this.stylebtn2);
            this.Controls.Add(this.stylebtn);
            this.Controls.Add(this.cyanbtn);
            this.Controls.Add(this.greenbtn);
            this.Controls.Add(this.yellowbtn);
            this.Controls.Add(this.orangebtn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.lblClock);
            this.Name = "digitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.digitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button orangebtn;
        private System.Windows.Forms.Button yellowbtn;
        private System.Windows.Forms.Button greenbtn;
        private System.Windows.Forms.Button cyanbtn;
        private System.Windows.Forms.Button stylebtn;
        private System.Windows.Forms.Button stylebtn2;
        private System.Windows.Forms.Button stylebtn3;
    }
}

