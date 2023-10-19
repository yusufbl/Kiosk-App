namespace CafeApp
{
    partial class Form4
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
            label2 = new Label();
            payButton2 = new Button();
            label3 = new Label();
            button1 = new Button();
            totalAmountLabel = new Label();
            label4 = new Label();
            billNoTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(133, 363);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Total Amount:";
            // 
            // payButton2
            // 
            payButton2.Location = new Point(237, 505);
            payButton2.Name = "payButton2";
            payButton2.Size = new Size(208, 132);
            payButton2.TabIndex = 2;
            payButton2.Text = "PAY";
            payButton2.UseVisualStyleBackColor = true;
            payButton2.Click += payButton2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(262, 42);
            label3.Name = "label3";
            label3.Size = new Size(197, 112);
            label3.TabIndex = 3;
            label3.Text = "BİLL";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(602, 269);
            button1.Name = "button1";
            button1.Size = new Size(116, 87);
            button1.TabIndex = 6;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            totalAmountLabel.Location = new Point(314, 350);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(214, 46);
            totalAmountLabel.TabIndex = 7;
            totalAmountLabel.Text = "total amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(133, 269);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 9;
            label4.Text = "Bill No:";
            // 
            // billNoTextBox
            // 
            billNoTextBox.Location = new Point(314, 269);
            billNoTextBox.Name = "billNoTextBox";
            billNoTextBox.Size = new Size(236, 27);
            billNoTextBox.TabIndex = 10;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 664);
            Controls.Add(billNoTextBox);
            Controls.Add(label4);
            Controls.Add(totalAmountLabel);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(payButton2);
            Controls.Add(label2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button payButton2;
        private Label label3;
        private Button button1;
        private Label totalAmountLabel;
        private Label label4;
        private TextBox billNoTextBox;
    }
}