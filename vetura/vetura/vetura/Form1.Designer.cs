namespace vetura
{
    partial class kyqu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kyqu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logclose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logusernamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logpasswordbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logkyqubtn = new System.Windows.Forms.Button();
            this.logregjistrohubtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logclose
            // 
            this.logclose.Image = ((System.Drawing.Image)(resources.GetObject("logclose.Image")));
            this.logclose.Location = new System.Drawing.Point(1010, -2);
            this.logclose.Name = "logclose";
            this.logclose.Size = new System.Drawing.Size(73, 52);
            this.logclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logclose.TabIndex = 2;
            this.logclose.TabStop = false;
            this.logclose.Click += new System.EventHandler(this.logclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName:";
            // 
            // logusernamebox
            // 
            this.logusernamebox.Location = new System.Drawing.Point(624, 255);
            this.logusernamebox.Name = "logusernamebox";
            this.logusernamebox.Size = new System.Drawing.Size(236, 20);
            this.logusernamebox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vetura";
            // 
            // logpasswordbox
            // 
            this.logpasswordbox.Location = new System.Drawing.Point(624, 303);
            this.logpasswordbox.Name = "logpasswordbox";
            this.logpasswordbox.Size = new System.Drawing.Size(236, 20);
            this.logpasswordbox.TabIndex = 8;
            this.logpasswordbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // logkyqubtn
            // 
            this.logkyqubtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logkyqubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logkyqubtn.Location = new System.Drawing.Point(624, 340);
            this.logkyqubtn.Name = "logkyqubtn";
            this.logkyqubtn.Size = new System.Drawing.Size(115, 37);
            this.logkyqubtn.TabIndex = 9;
            this.logkyqubtn.Text = "Kyqu";
            this.logkyqubtn.UseVisualStyleBackColor = false;
            this.logkyqubtn.Click += new System.EventHandler(this.logkyqubtn_Click);
            // 
            // logregjistrohubtn
            // 
            this.logregjistrohubtn.BackColor = System.Drawing.SystemColors.Control;
            this.logregjistrohubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logregjistrohubtn.Location = new System.Drawing.Point(745, 340);
            this.logregjistrohubtn.Name = "logregjistrohubtn";
            this.logregjistrohubtn.Size = new System.Drawing.Size(115, 37);
            this.logregjistrohubtn.TabIndex = 10;
            this.logregjistrohubtn.Text = "Regjistrohu";
            this.logregjistrohubtn.UseVisualStyleBackColor = false;
            this.logregjistrohubtn.Click += new System.EventHandler(this.logregjistrohubtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mundesoi:Arjan Krosa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(876, 575);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // kyqu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 607);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logregjistrohubtn);
            this.Controls.Add(this.logkyqubtn);
            this.Controls.Add(this.logpasswordbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logusernamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logclose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "kyqu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetura-Login";
            this.Load += new System.EventHandler(this.kyqu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logusernamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logpasswordbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logkyqubtn;
        private System.Windows.Forms.Button logregjistrohubtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

