namespace EMS.DesktopUI
{
    partial class ViewDetails
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
            this.btn6 = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(257, 181);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "Edit";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(17, 116);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(80, 23);
            this.lbl6.TabIndex = 12;
            this.lbl6.Text = "Password";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(17, 49);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(49, 23);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Details Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(157, 181);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "Cancel";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(107, 116);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(225, 20);
            this.txt7.TabIndex = 7;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(107, 52);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(225, 20);
            this.txt6.TabIndex = 6;
            // 
            // ViewDetails
            // 
            this.AcceptButton = this.btn6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 224);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Name = "ViewDetails";
            this.Text = "ViewDetails";
            this.Load += new System.EventHandler(this.ViewDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
    }
}