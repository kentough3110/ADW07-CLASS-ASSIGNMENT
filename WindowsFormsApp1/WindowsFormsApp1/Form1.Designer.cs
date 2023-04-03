namespace WindowsFormsApp1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtboxJumlahCells = new System.Windows.Forms.TextBox();
            this.lblJumlahCells = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(79, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtboxJumlahCells
            // 
            this.txtboxJumlahCells.Location = new System.Drawing.Point(68, 65);
            this.txtboxJumlahCells.Name = "txtboxJumlahCells";
            this.txtboxJumlahCells.Size = new System.Drawing.Size(100, 20);
            this.txtboxJumlahCells.TabIndex = 4;
            // 
            // lblJumlahCells
            // 
            this.lblJumlahCells.AutoSize = true;
            this.lblJumlahCells.Location = new System.Drawing.Point(65, 46);
            this.lblJumlahCells.Name = "lblJumlahCells";
            this.lblJumlahCells.Size = new System.Drawing.Size(114, 13);
            this.lblJumlahCells.TabIndex = 3;
            this.lblJumlahCells.Text = "Masukkan jumlah cells";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 172);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtboxJumlahCells);
            this.Controls.Add(this.lblJumlahCells);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtboxJumlahCells;
        private System.Windows.Forms.Label lblJumlahCells;
    }
}

