namespace Reflector_Keygen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.serialTextbox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.requestTextbox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.responseTextbox = new System.Windows.Forms.RichTextBox();
            this.lngTurkish = new System.Windows.Forms.PictureBox();
            this.lngEnglish = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lngTurkish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngEnglish)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AutoSize = true;
            this.minimizeBtn.Location = new System.Drawing.Point(586, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(17, 21);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Location = new System.Drawing.Point(605, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 21);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // serialTextbox
            // 
            this.serialTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialTextbox.Location = new System.Drawing.Point(24, 92);
            this.serialTextbox.Name = "serialTextbox";
            this.serialTextbox.ReadOnly = true;
            this.serialTextbox.Size = new System.Drawing.Size(463, 29);
            this.serialTextbox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(493, 91);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(64, 29);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // requestTextbox
            // 
            this.requestTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTextbox.Location = new System.Drawing.Point(24, 160);
            this.requestTextbox.Name = "requestTextbox";
            this.requestTextbox.Size = new System.Drawing.Size(463, 124);
            this.requestTextbox.TabIndex = 4;
            this.requestTextbox.Text = "";
            this.requestTextbox.TextChanged += new System.EventHandler(this.requestTextbox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(24, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = ".NET Reflector Keygen";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(20, 68);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(151, 21);
            this.serialLabel.TabIndex = 6;
            this.serialLabel.Text = "Generated serial key";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(20, 136);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(66, 21);
            this.requestLabel.TabIndex = 7;
            this.requestLabel.Text = "Request";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(20, 302);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(149, 21);
            this.responseLabel.TabIndex = 9;
            this.responseLabel.Text = "Generated response";
            // 
            // responseTextbox
            // 
            this.responseTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.responseTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTextbox.Location = new System.Drawing.Point(24, 326);
            this.responseTextbox.Name = "responseTextbox";
            this.responseTextbox.ReadOnly = true;
            this.responseTextbox.Size = new System.Drawing.Size(463, 131);
            this.responseTextbox.TabIndex = 8;
            this.responseTextbox.Text = "";
            // 
            // lngTurkish
            // 
            this.lngTurkish.Image = ((System.Drawing.Image)(resources.GetObject("lngTurkish.Image")));
            this.lngTurkish.Location = new System.Drawing.Point(24, 476);
            this.lngTurkish.Name = "lngTurkish";
            this.lngTurkish.Size = new System.Drawing.Size(45, 30);
            this.lngTurkish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lngTurkish.TabIndex = 10;
            this.lngTurkish.TabStop = false;
            this.lngTurkish.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lngEnglish
            // 
            this.lngEnglish.Image = ((System.Drawing.Image)(resources.GetObject("lngEnglish.Image")));
            this.lngEnglish.Location = new System.Drawing.Point(75, 476);
            this.lngEnglish.Name = "lngEnglish";
            this.lngEnglish.Size = new System.Drawing.Size(44, 30);
            this.lngEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lngEnglish.TabIndex = 11;
            this.lngEnglish.TabStop = false;
            this.lngEnglish.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(493, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(625, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lngEnglish);
            this.Controls.Add(this.lngTurkish);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.responseTextbox);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.requestTextbox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.serialTextbox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = ".NET Reflector Keygen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.lngTurkish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngEnglish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox serialTextbox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RichTextBox requestTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.RichTextBox responseTextbox;
        private System.Windows.Forms.PictureBox lngTurkish;
        private System.Windows.Forms.PictureBox lngEnglish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

