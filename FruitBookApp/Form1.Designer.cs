namespace FruitBookApp
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
            this.createFruitButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createFruitButton
            // 
            this.createFruitButton.Location = new System.Drawing.Point(46, 49);
            this.createFruitButton.Name = "createFruitButton";
            this.createFruitButton.Size = new System.Drawing.Size(178, 55);
            this.createFruitButton.TabIndex = 0;
            this.createFruitButton.Text = "Create fruit";
            this.createFruitButton.UseVisualStyleBackColor = true;
            this.createFruitButton.Click += new System.EventHandler(this.CreateFruitButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(329, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 304);
            this.listBox1.TabIndex = 1;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(46, 145);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(178, 67);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.createFruitButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titel Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createFruitButton;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button viewButton;
    }
}

