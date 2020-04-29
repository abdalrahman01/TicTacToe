namespace SLUTPROJEKT
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.P2 = new System.Windows.Forms.Button();
            this.AI = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.minTB = new System.Windows.Forms.Label();
            this.maxTB = new System.Windows.Forms.Label();
            this.streaklbl = new System.Windows.Forms.Label();
            this.streakn = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbarValue = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // P2
            // 
            this.P2.Enabled = false;
            this.P2.FlatAppearance.BorderSize = 0;
            this.P2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P2.Font = new System.Drawing.Font("Kristen ITC", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Location = new System.Drawing.Point(153, 62);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(147, 98);
            this.P2.TabIndex = 0;
            this.P2.Text = "P2";
            this.P2.UseVisualStyleBackColor = true;
            this.P2.Click += new System.EventHandler(this.P2_Click);
            this.P2.MouseEnter += new System.EventHandler(this.buttonsMouseEnter);
            this.P2.MouseLeave += new System.EventHandler(this.buttonsMouseLeave);
            // 
            // AI
            // 
            this.AI.FlatAppearance.BorderSize = 0;
            this.AI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AI.Font = new System.Drawing.Font("Kristen ITC", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AI.Location = new System.Drawing.Point(328, 62);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(147, 98);
            this.AI.TabIndex = 1;
            this.AI.Text = "AI";
            this.AI.UseVisualStyleBackColor = true;
            this.AI.Click += new System.EventHandler(this.AI_Click);
            this.AI.MouseEnter += new System.EventHandler(this.buttonsMouseEnter);
            this.AI.MouseLeave += new System.EventHandler(this.buttonsMouseLeave);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(180, 202);
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 69);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // minTB
            // 
            this.minTB.AutoSize = true;
            this.minTB.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTB.Location = new System.Drawing.Point(147, 202);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(32, 39);
            this.minTB.TabIndex = 4;
            this.minTB.Text = "3";
            // 
            // maxTB
            // 
            this.maxTB.AutoSize = true;
            this.maxTB.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTB.Location = new System.Drawing.Point(407, 202);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(47, 39);
            this.maxTB.TabIndex = 5;
            this.maxTB.Text = "10";
            // 
            // streaklbl
            // 
            this.streaklbl.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streaklbl.Location = new System.Drawing.Point(234, 325);
            this.streaklbl.Name = "streaklbl";
            this.streaklbl.Size = new System.Drawing.Size(185, 51);
            this.streaklbl.TabIndex = 6;
            this.streaklbl.Text = "STREAK";
            // 
            // streakn
            // 
            this.streakn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streakn.Location = new System.Drawing.Point(175, 325);
            this.streakn.Name = "streakn";
            this.streakn.Size = new System.Drawing.Size(53, 51);
            this.streakn.TabIndex = 7;
            this.streakn.Text = "3";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.label1);
            this.settings.Controls.Add(this.trackbarValue);
            this.settings.Controls.Add(this.trackBar1);
            this.settings.Controls.Add(this.streakn);
            this.settings.Controls.Add(this.P2);
            this.settings.Controls.Add(this.streaklbl);
            this.settings.Controls.Add(this.AI);
            this.settings.Controls.Add(this.maxTB);
            this.settings.Controls.Add(this.start);
            this.settings.Controls.Add(this.minTB);
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Location = new System.Drawing.Point(222, 58);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(494, 506);
            this.settings.TabIndex = 8;
            this.settings.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "SIZE";
            // 
            // trackbarValue
            // 
            this.trackbarValue.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarValue.Location = new System.Drawing.Point(263, 239);
            this.trackbarValue.Name = "trackbarValue";
            this.trackbarValue.Size = new System.Drawing.Size(83, 51);
            this.trackbarValue.TabIndex = 9;
            this.trackbarValue.Text = "3";
            // 
            // start
            // 
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Kristen ITC", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(154, 391);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(288, 88);
            this.start.TabIndex = 2;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_clicked);
            this.start.MouseEnter += new System.EventHandler(this.buttonsMouseEnter);
            this.start.MouseLeave += new System.EventHandler(this.buttonsMouseLeave);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 621);
            this.Controls.Add(this.settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "TicTacToe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button P2;
        private System.Windows.Forms.Button AI;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label minTB;
        private System.Windows.Forms.Label maxTB;
        private System.Windows.Forms.Label streaklbl;
        private System.Windows.Forms.Label streakn;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.Label trackbarValue;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
    }
}

