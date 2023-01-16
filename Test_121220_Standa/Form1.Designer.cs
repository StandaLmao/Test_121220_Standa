namespace Test_121220_Standa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.iFirstName = new System.Windows.Forms.TextBox();
            this.iLastName = new System.Windows.Forms.TextBox();
            this.iPhoneNum = new System.Windows.Forms.TextBox();
            this.iEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lId = new System.Windows.Forms.Label();
            this.lEmployees = new System.Windows.Forms.RichTextBox();
            this.iBirthDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iFirstName
            // 
            this.iFirstName.Location = new System.Drawing.Point(84, 56);
            this.iFirstName.Name = "iFirstName";
            this.iFirstName.Size = new System.Drawing.Size(200, 20);
            this.iFirstName.TabIndex = 0;
            // 
            // iLastName
            // 
            this.iLastName.Location = new System.Drawing.Point(84, 82);
            this.iLastName.Name = "iLastName";
            this.iLastName.Size = new System.Drawing.Size(200, 20);
            this.iLastName.TabIndex = 1;
            // 
            // iPhoneNum
            // 
            this.iPhoneNum.Location = new System.Drawing.Point(84, 108);
            this.iPhoneNum.Name = "iPhoneNum";
            this.iPhoneNum.Size = new System.Drawing.Size(200, 20);
            this.iPhoneNum.TabIndex = 2;
            // 
            // iEmail
            // 
            this.iEmail.Location = new System.Drawing.Point(84, 134);
            this.iEmail.Name = "iEmail";
            this.iEmail.Size = new System.Drawing.Size(200, 20);
            this.iEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Num.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birth Date";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(187, 186);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(97, 23);
            this.bSubmit.TabIndex = 10;
            this.bSubmit.Text = "Create";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(123, 186);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(26, 23);
            this.bLeft.TabIndex = 11;
            this.bLeft.Text = "<";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(155, 186);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(26, 23);
            this.bRight.TabIndex = 12;
            this.bRight.Text = ">";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(15, 186);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(102, 23);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(12, 25);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(22, 13);
            this.lId.TabIndex = 14;
            this.lId.Text = "Id: ";
            // 
            // lEmployees
            // 
            this.lEmployees.Location = new System.Drawing.Point(327, 13);
            this.lEmployees.Name = "lEmployees";
            this.lEmployees.Size = new System.Drawing.Size(461, 425);
            this.lEmployees.TabIndex = 15;
            this.lEmployees.Text = "";
            // 
            // iBirthDate
            // 
            this.iBirthDate.Location = new System.Drawing.Point(84, 163);
            this.iBirthDate.Name = "iBirthDate";
            this.iBirthDate.Size = new System.Drawing.Size(200, 20);
            this.iBirthDate.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iBirthDate);
            this.Controls.Add(this.lEmployees);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iEmail);
            this.Controls.Add(this.iPhoneNum);
            this.Controls.Add(this.iLastName);
            this.Controls.Add(this.iFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iFirstName;
        private System.Windows.Forms.TextBox iLastName;
        private System.Windows.Forms.TextBox iPhoneNum;
        private System.Windows.Forms.TextBox iEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.RichTextBox lEmployees;
        private System.Windows.Forms.TextBox iBirthDate;
    }
}

