namespace OCRProject
{
    partial class frmOCR_Project
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
            this.txtTextOutPut = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextOutPut
            // 
            this.txtTextOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextOutPut.Location = new System.Drawing.Point(12, 12);
            this.txtTextOutPut.Name = "txtTextOutPut";
            this.txtTextOutPut.ReadOnly = true;
            this.txtTextOutPut.Size = new System.Drawing.Size(745, 426);
            this.txtTextOutPut.TabIndex = 0;
            this.txtTextOutPut.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(24, 444);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(153, 20);
            this.btnFileSelect.TabIndex = 1;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilePath.Location = new System.Drawing.Point(183, 445);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(560, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.Location = new System.Drawing.Point(271, 496);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(236, 34);
            this.Read.TabIndex = 3;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // frmOCR_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 542);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.txtTextOutPut);
            this.Name = "frmOCR_Project";
            this.Text = "OCR Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTextOutPut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button Read;
    }
}

