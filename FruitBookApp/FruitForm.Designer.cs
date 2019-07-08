namespace FruitBookApp
{
    partial class FruitForm
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
            this.fruitNaamTextBox = new System.Windows.Forms.TextBox();
            this.houdbaarheidTextBox = new System.Windows.Forms.TextBox();
            this.fruitPictureBox = new System.Windows.Forms.PictureBox();
            this.createButton2 = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.filePathButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitNaamTextBox
            // 
            this.fruitNaamTextBox.Location = new System.Drawing.Point(24, 34);
            this.fruitNaamTextBox.Name = "fruitNaamTextBox";
            this.fruitNaamTextBox.Size = new System.Drawing.Size(223, 26);
            this.fruitNaamTextBox.TabIndex = 0;
            this.fruitNaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FruitNaamTextBox_Validating);
            // 
            // houdbaarheidTextBox
            // 
            this.houdbaarheidTextBox.Enabled = false;
            this.houdbaarheidTextBox.Location = new System.Drawing.Point(24, 84);
            this.houdbaarheidTextBox.Name = "houdbaarheidTextBox";
            this.houdbaarheidTextBox.ReadOnly = true;
            this.houdbaarheidTextBox.Size = new System.Drawing.Size(223, 26);
            this.houdbaarheidTextBox.TabIndex = 1;
            this.houdbaarheidTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoudbaarheidTextBox_Validating);
            // 
            // fruitPictureBox
            // 
            this.fruitPictureBox.ImageLocation = "c:\\Fruit\\appel.jpg";
            this.fruitPictureBox.Location = new System.Drawing.Point(353, 34);
            this.fruitPictureBox.Name = "fruitPictureBox";
            this.fruitPictureBox.Size = new System.Drawing.Size(346, 240);
            this.fruitPictureBox.TabIndex = 2;
            this.fruitPictureBox.TabStop = false;
            // 
            // createButton2
            // 
            this.createButton2.Location = new System.Drawing.Point(38, 222);
            this.createButton2.Name = "createButton2";
            this.createButton2.Size = new System.Drawing.Size(159, 52);
            this.createButton2.TabIndex = 3;
            this.createButton2.Text = "Create";
            this.createButton2.UseVisualStyleBackColor = true;
            this.createButton2.Click += new System.EventHandler(this.CreateButton2_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Enabled = false;
            this.filePathBox.Location = new System.Drawing.Point(375, 300);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(312, 26);
            this.filePathBox.TabIndex = 4;
            this.filePathBox.Validating += new System.ComponentModel.CancelEventHandler(this.FilePathBox_Validating);
            // 
            // filePathButton
            // 
            this.filePathButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filePathButton.Location = new System.Drawing.Point(375, 355);
            this.filePathButton.Name = "filePathButton";
            this.filePathButton.Size = new System.Drawing.Size(145, 24);
            this.filePathButton.TabIndex = 5;
            this.filePathButton.Text = "File";
            this.filePathButton.UseVisualStyleBackColor = true;
            this.filePathButton.Click += new System.EventHandler(this.FilePathButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 136);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 7, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePicker1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(40, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(157, 53);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FruitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filePathButton);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.createButton2);
            this.Controls.Add(this.fruitPictureBox);
            this.Controls.Add(this.houdbaarheidTextBox);
            this.Controls.Add(this.fruitNaamTextBox);
            this.Name = "FruitForm";
            this.Text = "Fruit";
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fruitNaamTextBox;
        private System.Windows.Forms.TextBox houdbaarheidTextBox;
        private System.Windows.Forms.PictureBox fruitPictureBox;
        private System.Windows.Forms.Button createButton2;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button filePathButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelButton;
    }
}