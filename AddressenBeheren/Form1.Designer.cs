namespace AddressenBeheren
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
            this.components = new System.ComponentModel.Container();
            this.lijstPanel = new System.Windows.Forms.Panel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.leeftijdLabel = new System.Windows.Forms.Label();
            this.achternaamLabel = new System.Windows.Forms.Label();
            this.voornaamLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lijstPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lijstPanel
            // 
            this.lijstPanel.Controls.Add(this.buttonDown);
            this.lijstPanel.Controls.Add(this.buttonUp);
            this.lijstPanel.Controls.Add(this.listBox1);
            this.lijstPanel.Location = new System.Drawing.Point(8, 13);
            this.lijstPanel.Name = "lijstPanel";
            this.lijstPanel.Size = new System.Drawing.Size(451, 450);
            this.lijstPanel.TabIndex = 0;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(266, 389);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(83, 31);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(116, 387);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(63, 34);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(392, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.leeftijdLabel);
            this.detailPanel.Controls.Add(this.achternaamLabel);
            this.detailPanel.Controls.Add(this.voornaamLabel);
            this.detailPanel.Location = new System.Drawing.Point(475, 16);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(447, 446);
            this.detailPanel.TabIndex = 1;
            // 
            // leeftijdLabel
            // 
            this.leeftijdLabel.AutoSize = true;
            this.leeftijdLabel.Location = new System.Drawing.Point(81, 137);
            this.leeftijdLabel.Name = "leeftijdLabel";
            this.leeftijdLabel.Size = new System.Drawing.Size(61, 20);
            this.leeftijdLabel.TabIndex = 2;
            this.leeftijdLabel.Text = "Leeftijd";
            // 
            // achternaamLabel
            // 
            this.achternaamLabel.AutoSize = true;
            this.achternaamLabel.Location = new System.Drawing.Point(78, 82);
            this.achternaamLabel.Name = "achternaamLabel";
            this.achternaamLabel.Size = new System.Drawing.Size(96, 20);
            this.achternaamLabel.TabIndex = 1;
            this.achternaamLabel.Text = "Achternaam";
            // 
            // voornaamLabel
            // 
            this.voornaamLabel.AutoSize = true;
            this.voornaamLabel.Location = new System.Drawing.Point(85, 35);
            this.voornaamLabel.Name = "voornaamLabel";
            this.voornaamLabel.Size = new System.Drawing.Size(83, 20);
            this.voornaamLabel.TabIndex = 0;
            this.voornaamLabel.Text = "Voornaam";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 728);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.lijstPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lijstPanel.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lijstPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Label achternaamLabel;
        private System.Windows.Forms.Label voornaamLabel;
        private System.Windows.Forms.Label leeftijdLabel;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Timer timer1;
    }
}

