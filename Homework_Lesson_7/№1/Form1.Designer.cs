namespace _1
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
            this.BtnCommand1 = new System.Windows.Forms.Button();
            this.BtnCommand2 = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblNumber = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblTryNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCommand1
            // 
            this.BtnCommand1.Location = new System.Drawing.Point(187, 28);
            this.BtnCommand1.Name = "BtnCommand1";
            this.BtnCommand1.Size = new System.Drawing.Size(75, 23);
            this.BtnCommand1.TabIndex = 0;
            this.BtnCommand1.Text = "button1";
            this.BtnCommand1.UseVisualStyleBackColor = true;
            this.BtnCommand1.Click += new System.EventHandler(this.BtnCommand1_Click);
            // 
            // BtnCommand2
            // 
            this.BtnCommand2.Location = new System.Drawing.Point(187, 61);
            this.BtnCommand2.Name = "BtnCommand2";
            this.BtnCommand2.Size = new System.Drawing.Size(75, 23);
            this.BtnCommand2.TabIndex = 1;
            this.BtnCommand2.Text = "button2";
            this.BtnCommand2.UseVisualStyleBackColor = true;
            this.BtnCommand2.Click += new System.EventHandler(this.BtnCommand2_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(187, 112);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "button3";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNumber.Location = new System.Drawing.Point(83, 51);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(29, 31);
            this.LblNumber.TabIndex = 3;
            this.LblNumber.Text = "0";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(38, 117);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(55, 13);
            this.lblTry.TabIndex = 4;
            this.lblTry.Text = "Попытки:";
            // 
            // lblTryNum
            // 
            this.lblTryNum.AutoSize = true;
            this.lblTryNum.Location = new System.Drawing.Point(99, 117);
            this.lblTryNum.Name = "lblTryNum";
            this.lblTryNum.Size = new System.Drawing.Size(13, 13);
            this.lblTryNum.TabIndex = 5;
            this.lblTryNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Нужное число:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(99, 9);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(13, 13);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 146);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTryNum);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCommand2);
            this.Controls.Add(this.BtnCommand1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCommand1;
        private System.Windows.Forms.Button BtnCommand2;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblTryNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarget;
    }
}

