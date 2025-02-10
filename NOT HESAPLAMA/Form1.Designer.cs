namespace NOT_HESAPLAMA
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.navarPanel = new System.Windows.Forms.Panel();
            this.miniMazeBTN = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sNot1 = new System.Windows.Forms.TextBox();
            this.s1Labelİnfo = new System.Windows.Forms.Label();
            this.s2LABELinfo = new System.Windows.Forms.Label();
            this.sNot2 = new System.Windows.Forms.TextBox();
            this.sözNo2 = new System.Windows.Forms.Label();
            this.sozN2 = new System.Windows.Forms.TextBox();
            this.sozluLabelİNFO = new System.Windows.Forms.Label();
            this.sozN1 = new System.Windows.Forms.TextBox();
            this.hspBTN = new System.Windows.Forms.Button();
            this.sncListBX = new System.Windows.Forms.ListBox();
            this.navarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navarPanel
            // 
            this.navarPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.navarPanel.Controls.Add(this.miniMazeBTN);
            this.navarPanel.Controls.Add(this.quitButton);
            this.navarPanel.Location = new System.Drawing.Point(0, 0);
            this.navarPanel.Name = "navarPanel";
            this.navarPanel.Size = new System.Drawing.Size(800, 49);
            this.navarPanel.TabIndex = 1;
            this.navarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navarPanel_Paint);
            this.navarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navarPanel_MouseDown);
            this.navarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navarPanel_MouseMove);
            this.navarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navarPanel_MouseUp);
            // 
            // miniMazeBTN
            // 
            this.miniMazeBTN.BackColor = System.Drawing.Color.Transparent;
            this.miniMazeBTN.BackgroundImage = global::NOT_HESAPLAMA.Properties.Resources.minimaze;
            this.miniMazeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniMazeBTN.FlatAppearance.BorderSize = 0;
            this.miniMazeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniMazeBTN.Location = new System.Drawing.Point(689, 2);
            this.miniMazeBTN.Name = "miniMazeBTN";
            this.miniMazeBTN.Size = new System.Drawing.Size(52, 44);
            this.miniMazeBTN.TabIndex = 1;
            this.miniMazeBTN.UseVisualStyleBackColor = false;
            this.miniMazeBTN.Click += new System.EventHandler(this.miniMazeBTN_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = global::NOT_HESAPLAMA.Properties.Resources.X;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Location = new System.Drawing.Point(747, 3);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(52, 44);
            this.quitButton.TabIndex = 0;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.sncListBX);
            this.mainPanel.Controls.Add(this.hspBTN);
            this.mainPanel.Controls.Add(this.sözNo2);
            this.mainPanel.Controls.Add(this.sozN2);
            this.mainPanel.Controls.Add(this.sozluLabelİNFO);
            this.mainPanel.Controls.Add(this.sozN1);
            this.mainPanel.Controls.Add(this.s2LABELinfo);
            this.mainPanel.Controls.Add(this.sNot2);
            this.mainPanel.Controls.Add(this.s1Labelİnfo);
            this.mainPanel.Controls.Add(this.sNot1);
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 400);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // sNot1
            // 
            this.sNot1.BackColor = System.Drawing.Color.White;
            this.sNot1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNot1.Location = new System.Drawing.Point(27, 57);
            this.sNot1.Name = "sNot1";
            this.sNot1.Size = new System.Drawing.Size(158, 13);
            this.sNot1.TabIndex = 0;
            // 
            // s1Labelİnfo
            // 
            this.s1Labelİnfo.AutoSize = true;
            this.s1Labelİnfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.s1Labelİnfo.ForeColor = System.Drawing.Color.White;
            this.s1Labelİnfo.Location = new System.Drawing.Point(24, 36);
            this.s1Labelİnfo.Name = "s1Labelİnfo";
            this.s1Labelİnfo.Size = new System.Drawing.Size(113, 18);
            this.s1Labelİnfo.TabIndex = 1;
            this.s1Labelİnfo.Text = "1. SINAV NOTU";
            this.s1Labelİnfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s2LABELinfo
            // 
            this.s2LABELinfo.AutoSize = true;
            this.s2LABELinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.s2LABELinfo.ForeColor = System.Drawing.Color.White;
            this.s2LABELinfo.Location = new System.Drawing.Point(243, 36);
            this.s2LABELinfo.Name = "s2LABELinfo";
            this.s2LABELinfo.Size = new System.Drawing.Size(96, 18);
            this.s2LABELinfo.TabIndex = 3;
            this.s2LABELinfo.Text = "2. Sınav Notu";
            // 
            // sNot2
            // 
            this.sNot2.BackColor = System.Drawing.Color.White;
            this.sNot2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNot2.Location = new System.Drawing.Point(246, 57);
            this.sNot2.Name = "sNot2";
            this.sNot2.Size = new System.Drawing.Size(158, 13);
            this.sNot2.TabIndex = 2;
            // 
            // sözNo2
            // 
            this.sözNo2.AutoSize = true;
            this.sözNo2.BackColor = System.Drawing.Color.Transparent;
            this.sözNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.sözNo2.ForeColor = System.Drawing.Color.White;
            this.sözNo2.Location = new System.Drawing.Point(241, 86);
            this.sözNo2.Name = "sözNo2";
            this.sözNo2.Size = new System.Drawing.Size(98, 18);
            this.sözNo2.TabIndex = 7;
            this.sözNo2.Text = "2. Sözlü Notu";
            // 
            // sozN2
            // 
            this.sozN2.BackColor = System.Drawing.Color.White;
            this.sozN2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sozN2.Location = new System.Drawing.Point(244, 107);
            this.sozN2.Name = "sozN2";
            this.sozN2.Size = new System.Drawing.Size(158, 13);
            this.sozN2.TabIndex = 6;
            // 
            // sozluLabelİNFO
            // 
            this.sozluLabelİNFO.AutoSize = true;
            this.sozluLabelİNFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.sozluLabelİNFO.ForeColor = System.Drawing.Color.White;
            this.sozluLabelİNFO.Location = new System.Drawing.Point(24, 86);
            this.sozluLabelİNFO.Name = "sozluLabelİNFO";
            this.sozluLabelİNFO.Size = new System.Drawing.Size(98, 18);
            this.sozluLabelİNFO.TabIndex = 5;
            this.sozluLabelİNFO.Text = "1. Sözlü Notu";
            // 
            // sozN1
            // 
            this.sozN1.BackColor = System.Drawing.Color.White;
            this.sozN1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sozN1.Location = new System.Drawing.Point(27, 107);
            this.sozN1.Name = "sozN1";
            this.sozN1.Size = new System.Drawing.Size(158, 13);
            this.sozN1.TabIndex = 4;
            // 
            // hspBTN
            // 
            this.hspBTN.BackColor = System.Drawing.Color.Transparent;
            this.hspBTN.FlatAppearance.BorderSize = 15;
            this.hspBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hspBTN.ForeColor = System.Drawing.Color.Transparent;
            this.hspBTN.Location = new System.Drawing.Point(124, 157);
            this.hspBTN.Name = "hspBTN";
            this.hspBTN.Size = new System.Drawing.Size(167, 91);
            this.hspBTN.TabIndex = 8;
            this.hspBTN.Text = "Hesapla";
            this.hspBTN.UseVisualStyleBackColor = false;
            this.hspBTN.Click += new System.EventHandler(this.hspBTN_Click);
            // 
            // sncListBX
            // 
            this.sncListBX.FormattingEnabled = true;
            this.sncListBX.Location = new System.Drawing.Point(499, 36);
            this.sncListBX.Name = "sncListBX";
            this.sncListBX.Size = new System.Drawing.Size(233, 303);
            this.sncListBX.TabIndex = 9;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navarPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel navarPanel;
        private System.Windows.Forms.Button miniMazeBTN;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label sözNo2;
        private System.Windows.Forms.TextBox sozN2;
        private System.Windows.Forms.Label sozluLabelİNFO;
        private System.Windows.Forms.TextBox sozN1;
        private System.Windows.Forms.Label s2LABELinfo;
        private System.Windows.Forms.TextBox sNot2;
        private System.Windows.Forms.Label s1Labelİnfo;
        private System.Windows.Forms.TextBox sNot1;
        private System.Windows.Forms.Button hspBTN;
        private System.Windows.Forms.ListBox sncListBX;
    }
}

