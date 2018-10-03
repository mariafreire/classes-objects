namespace Classes_Objects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPhoneInfo = new System.Windows.Forms.Button();
            this.btnPhoneInfoCallMethod = new System.Windows.Forms.Button();
            this.btnGetDiscount = new System.Windows.Forms.Button();
            this.btnUsingOtherConstructors = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsingOtherConstructors);
            this.groupBox1.Controls.Add(this.btnGetDiscount);
            this.groupBox1.Controls.Add(this.btnPhoneInfoCallMethod);
            this.groupBox1.Controls.Add(this.btnPhoneInfo);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demonstration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(225, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Practices";
            // 
            // btnPhoneInfo
            // 
            this.btnPhoneInfo.Location = new System.Drawing.Point(27, 32);
            this.btnPhoneInfo.Name = "btnPhoneInfo";
            this.btnPhoneInfo.Size = new System.Drawing.Size(125, 23);
            this.btnPhoneInfo.TabIndex = 0;
            this.btnPhoneInfo.Text = "Phone Information";
            this.btnPhoneInfo.UseVisualStyleBackColor = true;
            this.btnPhoneInfo.Click += new System.EventHandler(this.btnPhoneInfo_Click);
            // 
            // btnPhoneInfoCallMethod
            // 
            this.btnPhoneInfoCallMethod.Location = new System.Drawing.Point(27, 61);
            this.btnPhoneInfoCallMethod.Name = "btnPhoneInfoCallMethod";
            this.btnPhoneInfoCallMethod.Size = new System.Drawing.Size(125, 23);
            this.btnPhoneInfoCallMethod.TabIndex = 1;
            this.btnPhoneInfoCallMethod.Text = "Phone Info Using Method";
            this.btnPhoneInfoCallMethod.UseVisualStyleBackColor = true;
            this.btnPhoneInfoCallMethod.Click += new System.EventHandler(this.btnPhoneInfoCallMethod_Click);
            // 
            // btnGetDiscount
            // 
            this.btnGetDiscount.Location = new System.Drawing.Point(27, 90);
            this.btnGetDiscount.Name = "btnGetDiscount";
            this.btnGetDiscount.Size = new System.Drawing.Size(125, 23);
            this.btnGetDiscount.TabIndex = 2;
            this.btnGetDiscount.Text = "Get a Discount";
            this.btnGetDiscount.UseVisualStyleBackColor = true;
            this.btnGetDiscount.Click += new System.EventHandler(this.btnGetDiscount_Click);
            // 
            // btnUsingOtherConstructors
            // 
            this.btnUsingOtherConstructors.Location = new System.Drawing.Point(27, 119);
            this.btnUsingOtherConstructors.Name = "btnUsingOtherConstructors";
            this.btnUsingOtherConstructors.Size = new System.Drawing.Size(125, 23);
            this.btnUsingOtherConstructors.TabIndex = 3;
            this.btnUsingOtherConstructors.Text = "Using Constructors";
            this.btnUsingOtherConstructors.UseVisualStyleBackColor = true;
            this.btnUsingOtherConstructors.Click += new System.EventHandler(this.btnUsingOtherConstructors_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "practice1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "practice2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 107);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 308);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Classes and Objects";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsingOtherConstructors;
        private System.Windows.Forms.Button btnGetDiscount;
        private System.Windows.Forms.Button btnPhoneInfoCallMethod;
        private System.Windows.Forms.Button btnPhoneInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

