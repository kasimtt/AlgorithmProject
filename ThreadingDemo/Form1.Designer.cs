namespace ThreadingDemo
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
            this.btn_process1 = new System.Windows.Forms.Button();
            this.btn_process2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_process1
            // 
            this.btn_process1.Location = new System.Drawing.Point(172, 114);
            this.btn_process1.Name = "btn_process1";
            this.btn_process1.Size = new System.Drawing.Size(110, 52);
            this.btn_process1.TabIndex = 0;
            this.btn_process1.Text = "İşlem1";
            this.btn_process1.UseVisualStyleBackColor = true;
            this.btn_process1.Click += new System.EventHandler(this.btn_process1_Click);
            // 
            // btn_process2
            // 
            this.btn_process2.Location = new System.Drawing.Point(358, 114);
            this.btn_process2.Name = "btn_process2";
            this.btn_process2.Size = new System.Drawing.Size(107, 52);
            this.btn_process2.TabIndex = 1;
            this.btn_process2.Text = "işlem2";
            this.btn_process2.UseVisualStyleBackColor = true;
            this.btn_process2.Click += new System.EventHandler(this.btn_process2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_process2);
            this.Controls.Add(this.btn_process1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_process1;
        private System.Windows.Forms.Button btn_process2;
    }
}

