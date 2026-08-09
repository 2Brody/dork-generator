namespace DorkMaster
{
    partial class FormJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTextShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNotNow = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(386, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTextShow
            // 
            this.lblTextShow.AutoSize = true;
            this.lblTextShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextShow.Location = new System.Drawing.Point(88, 83);
            this.lblTextShow.Name = "lblTextShow";
            this.lblTextShow.Size = new System.Drawing.Size(25, 21);
            this.lblTextShow.TabIndex = 1;
            this.lblTextShow.Text = "Jo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNotNow
            // 
            this.btnNotNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnNotNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotNow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotNow.Location = new System.Drawing.Point(220, 144);
            this.btnNotNow.Name = "btnNotNow";
            this.btnNotNow.Size = new System.Drawing.Size(75, 25);
            this.btnNotNow.TabIndex = 3;
            this.btnNotNow.Text = "Not Now";
            this.btnNotNow.UseVisualStyleBackColor = false;
            this.btnNotNow.Click += new System.EventHandler(this.btnNotNow_Click);
            this.btnNotNow.MouseEnter += new System.EventHandler(this.btnNotNow_MouseEnter);
            this.btnNotNow.MouseLeave += new System.EventHandler(this.btnNotNow_MouseLeave);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJoin.Location = new System.Drawing.Point(125, 144);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 25);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            this.btnJoin.MouseEnter += new System.EventHandler(this.btnJoin_MouseEnter);
            this.btnJoin.MouseLeave += new System.EventHandler(this.btnJoin_MouseLeave);
            // 
            // FormJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnNotNow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTextShow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJoin";
            this.Load += new System.EventHandler(this.FormJoin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTextShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNotNow;
        private System.Windows.Forms.Button btnJoin;
    }
}