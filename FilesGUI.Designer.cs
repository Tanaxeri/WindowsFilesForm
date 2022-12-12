namespace WindowsFilesForm
{
    partial class FilesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.FajlSzov_Box = new System.Windows.Forms.RichTextBox();
            this.NevText = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FileSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.Openbutton = new System.Windows.Forms.Button();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(399, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fájlkezelő Form";
            // 
            // FajlSzov_Box
            // 
            this.FajlSzov_Box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FajlSzov_Box.Location = new System.Drawing.Point(0, 378);
            this.FajlSzov_Box.Name = "FajlSzov_Box";
            this.FajlSzov_Box.Size = new System.Drawing.Size(1200, 280);
            this.FajlSzov_Box.TabIndex = 1;
            this.FajlSzov_Box.Text = "";
            // 
            // NevText
            // 
            this.NevText.Location = new System.Drawing.Point(107, 177);
            this.NevText.Name = "NevText";
            this.NevText.Size = new System.Drawing.Size(211, 26);
            this.NevText.TabIndex = 2;
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(12, 177);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(75, 19);
            this.filename.TabIndex = 3;
            this.filename.Text = "Fájl neve:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(16, 281);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(159, 64);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Openbutton
            // 
            this.Openbutton.Location = new System.Drawing.Point(218, 281);
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.Size = new System.Drawing.Size(150, 64);
            this.Openbutton.TabIndex = 5;
            this.Openbutton.Text = "Megnyitás";
            this.Openbutton.UseVisualStyleBackColor = true;
            this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileName = "openFileDialog1";
            // 
            // FilesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.NevText);
            this.Controls.Add(this.FajlSzov_Box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FilesGUI";
            this.Text = "FilesGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox FajlSzov_Box;
        private System.Windows.Forms.TextBox NevText;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog FileSaveDialog;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.OpenFileDialog FileOpenDialog;
    }
}

