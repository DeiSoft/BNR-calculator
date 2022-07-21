namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pr_textBox = new System.Windows.Forms.TextBox();
            this.am_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sum_text = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_monthMoney = new System.Windows.Forms.Label();
            this.txt_click = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pr_textBox
            // 
            this.pr_textBox.Location = new System.Drawing.Point(84, 115);
            this.pr_textBox.Name = "pr_textBox";
            this.pr_textBox.Size = new System.Drawing.Size(100, 23);
            this.pr_textBox.TabIndex = 0;
            // 
            // am_textBox
            // 
            this.am_textBox.Location = new System.Drawing.Point(68, 139);
            this.am_textBox.Name = "am_textBox";
            this.am_textBox.Size = new System.Drawing.Size(100, 23);
            this.am_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sum_text
            // 
            this.sum_text.AutoSize = true;
            this.sum_text.Location = new System.Drawing.Point(245, 242);
            this.sum_text.Name = "sum_text";
            this.sum_text.Size = new System.Drawing.Size(13, 15);
            this.sum_text.TabIndex = 5;
            this.sum_text.Text = "0";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_total.Location = new System.Drawing.Point(385, 128);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(128, 47);
            this.txt_total.TabIndex = 7;
            this.txt_total.Text = "TOTAL";
            // 
            // txt_monthMoney
            // 
            this.txt_monthMoney.AutoSize = true;
            this.txt_monthMoney.Location = new System.Drawing.Point(245, 265);
            this.txt_monthMoney.Name = "txt_monthMoney";
            this.txt_monthMoney.Size = new System.Drawing.Size(13, 15);
            this.txt_monthMoney.TabIndex = 8;
            this.txt_monthMoney.Text = "0";
            // 
            // txt_click
            // 
            this.txt_click.AutoSize = true;
            this.txt_click.Location = new System.Drawing.Point(385, 18);
            this.txt_click.Name = "txt_click";
            this.txt_click.Size = new System.Drawing.Size(13, 15);
            this.txt_click.TabIndex = 9;
            this.txt_click.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "month: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_click);
            this.Controls.Add(this.txt_monthMoney);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.sum_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.am_textBox);
            this.Controls.Add(this.pr_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pr_textBox;
        private TextBox am_textBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label sum_text;
        private Label txt_total;
        private Label txt_monthMoney;
        private Label txt_click;
        private Label label3;
    }
}