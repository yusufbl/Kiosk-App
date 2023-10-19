namespace CafeApp
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
            registerButton1 = new Button();
            userNameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            passwordTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // registerButton1
            // 
            registerButton1.Location = new Point(498, 410);
            registerButton1.Name = "registerButton1";
            registerButton1.Size = new Size(210, 193);
            registerButton1.TabIndex = 0;
            registerButton1.Text = "ENTRY";
            registerButton1.UseVisualStyleBackColor = true;
            registerButton1.Click += registerButton1_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(757, 168);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(337, 27);
            userNameTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(757, 242);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(337, 27);
            surnameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(151, 168);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(337, 27);
            idTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(151, 242);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(337, 27);
            nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, 33);
            label1.Name = "label1";
            label1.Size = new Size(189, 89);
            label1.TabIndex = 5;
            label1.Text = "CAFE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 171);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 171);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "User ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(658, 245);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 245);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "Name:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(151, 315);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(337, 27);
            passwordTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 315);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 636);
            Controls.Add(label6);
            Controls.Add(passwordTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(registerButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton1;
        private TextBox userNameTextBox;
        private TextBox surnameTextBox;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox passwordTextBox;
        private Label label6;
    }
}