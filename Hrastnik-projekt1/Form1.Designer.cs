namespace Hrastnik_projekt1
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
            this.btnnew = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnreveal = new System.Windows.Forms.Button();
            this.btnguess = new System.Windows.Forms.Button();
            this.lblwordlenght = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(261, 67);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "new word";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnreveal
            // 
            this.btnreveal.Location = new System.Drawing.Point(261, 96);
            this.btnreveal.Name = "btnreveal";
            this.btnreveal.Size = new System.Drawing.Size(75, 23);
            this.btnreveal.TabIndex = 3;
            this.btnreveal.Text = "reveal";
            this.btnreveal.UseVisualStyleBackColor = true;
            this.btnreveal.Click += new System.EventHandler(this.btnreveal_Click);
            // 
            // btnguess
            // 
            this.btnguess.Location = new System.Drawing.Point(261, 38);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(75, 23);
            this.btnguess.TabIndex = 4;
            this.btnguess.Text = "guess";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // lblwordlenght
            // 
            this.lblwordlenght.AutoSize = true;
            this.lblwordlenght.Location = new System.Drawing.Point(220, 19);
            this.lblwordlenght.Name = "lblwordlenght";
            this.lblwordlenght.Size = new System.Drawing.Size(0, 13);
            this.lblwordlenght.TabIndex = 5;
            this.lblwordlenght.Click += new System.EventHandler(this.lblwordlenght_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 136);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Insert new";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblwordlenght);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.btnreveal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnreveal;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Label lblwordlenght;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

