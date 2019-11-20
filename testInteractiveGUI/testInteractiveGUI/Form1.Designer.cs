namespace testInteractiveGUI
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
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(251, 133);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(100, 20);
            this.txtScore4.TabIndex = 0;
            // 
            // txtScore5
            // 
            this.txtScore5.Location = new System.Drawing.Point(62, 225);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(100, 20);
            this.txtScore5.TabIndex = 1;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(251, 39);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(62, 133);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 3;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(62, 39);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 4;
            this.txtScore1.TextChanged += new System.EventHandler(this.txtScore1_TextChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(480, 208);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Click here";
            this.btncalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Test Score";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(251, 212);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(100, 23);
            this.lblresult.TabIndex = 7;
            this.lblresult.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
    }
}

