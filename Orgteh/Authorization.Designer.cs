using System.Drawing;

namespace Orgteh
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelAuthorization = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxpass = new TextBox();
            buttonEnter = new Button();
            timerEnter = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBoxCaptcha = new TextBox();
            label1 = new Label();
            buttonUpdcaptcha = new Button();
            panelсaptch = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelсaptch.SuspendLayout();
            SuspendLayout();
            // 
            // labelAuthorization
            // 
            labelAuthorization.AutoSize = true;
            labelAuthorization.Font = new Font("Garamond", 24F);
            labelAuthorization.Location = new Point(62, 20);
            labelAuthorization.Margin = new Padding(4, 0, 4, 0);
            labelAuthorization.Name = "labelAuthorization";
            labelAuthorization.Size = new Size(316, 36);
            labelAuthorization.TabIndex = 0;
            labelAuthorization.Text = "Авторизация в систему";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Garamond", 12F);
            labelLogin.Location = new Point(75, 106);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(51, 18);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Garamond", 12F);
            labelPassword.Location = new Point(68, 139);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 18);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(149, 143, 143);
            textBoxLogin.Font = new Font("Garamond", 12F);
            textBoxLogin.ForeColor = SystemColors.WindowText;
            textBoxLogin.Location = new Point(134, 103);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(142, 25);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxpass
            // 
            textBoxpass.BackColor = Color.FromArgb(149, 143, 143);
            textBoxpass.Font = new Font("Garamond", 12F);
            textBoxpass.ForeColor = SystemColors.WindowText;
            textBoxpass.Location = new Point(134, 136);
            textBoxpass.Margin = new Padding(4, 3, 4, 3);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(142, 25);
            textBoxpass.TabIndex = 4;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(149, 143, 143);
            buttonEnter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEnter.FlatAppearance.BorderColor = Color.Black;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Garamond", 14F);
            buttonEnter.ForeColor = Color.Black;
            buttonEnter.Location = new Point(81, 172);
            buttonEnter.Margin = new Padding(4, 3, 4, 3);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(266, 40);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "Вход";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonLogin_Click;
            // 
            // timerEnter
            // 
            timerEnter.Tick += timerEnter_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.Location = new Point(281, 142);
            label2.Name = "label2";
            label2.Size = new Size(97, 14);
            label2.TabIndex = 13;
            label2.Text = "Показать пароль";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F);
            label3.Location = new Point(64, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(225, 21);
            label3.TabIndex = 14;
            label3.Text = "Пожалуйста, авторизуйтесь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(8, 3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 18);
            label4.TabIndex = 15;
            label4.Text = "Для продолжения пройдите капчу";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(79, 58);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 42);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.BackColor = Color.FromArgb(149, 143, 143);
            textBoxCaptcha.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCaptcha.Location = new Point(58, 29);
            textBoxCaptcha.Margin = new Padding(4, 3, 4, 3);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(103, 25);
            textBoxCaptcha.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 10;
            label1.Text = "Ответ";
            // 
            // buttonUpdcaptcha
            // 
            buttonUpdcaptcha.BackColor = Color.FromArgb(149, 143, 143);
            buttonUpdcaptcha.FlatStyle = FlatStyle.Flat;
            buttonUpdcaptcha.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUpdcaptcha.ForeColor = Color.Black;
            buttonUpdcaptcha.Location = new Point(170, 29);
            buttonUpdcaptcha.Margin = new Padding(4, 3, 4, 3);
            buttonUpdcaptcha.Name = "buttonUpdcaptcha";
            buttonUpdcaptcha.Size = new Size(87, 25);
            buttonUpdcaptcha.TabIndex = 8;
            buttonUpdcaptcha.Text = "Обновить";
            buttonUpdcaptcha.UseVisualStyleBackColor = false;
            buttonUpdcaptcha.Click += buttonNewCaptcha_Click;
            // 
            // panelсaptch
            // 
            panelсaptch.Controls.Add(label4);
            panelсaptch.Controls.Add(buttonUpdcaptcha);
            panelсaptch.Controls.Add(pictureBox1);
            panelсaptch.Controls.Add(label1);
            panelсaptch.Controls.Add(textBoxCaptcha);
            panelсaptch.Location = new Point(81, 221);
            panelсaptch.Margin = new Padding(4, 3, 4, 3);
            panelсaptch.Name = "panelсaptch";
            panelсaptch.Size = new Size(266, 107);
            panelсaptch.TabIndex = 12;
            panelсaptch.Visible = false;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(443, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxpass);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(labelAuthorization);
            Controls.Add(panelсaptch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Authorization";
            Text = "Авторизация";
            FormClosed += Authorization_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelсaptch.ResumeLayout(false);
            panelсaptch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAuthorization;
        public System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Timer timerEnter;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBoxCaptcha;
        private Label label1;
        private Button buttonUpdcaptcha;
        private Panel panelсaptch;
    }
}

