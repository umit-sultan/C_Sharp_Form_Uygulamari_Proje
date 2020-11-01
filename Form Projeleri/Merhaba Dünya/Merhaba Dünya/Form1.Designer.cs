namespace Merhaba_Dünya
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
            this.tıklayın = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tıklayın
            // 
            this.tıklayın.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tıklayın.Location = new System.Drawing.Point(251, 140);
            this.tıklayın.Name = "tıklayın";
            this.tıklayın.Size = new System.Drawing.Size(332, 153);
            this.tıklayın.TabIndex = 0;
            this.tıklayın.Text = "Tıklayın";
            this.tıklayın.UseVisualStyleBackColor = true;
            this.tıklayın.Click += new System.EventHandler(this.tıklayın_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 492);
            this.Controls.Add(this.tıklayın);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Merhaba Dünya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tıklayın;
    }
}

