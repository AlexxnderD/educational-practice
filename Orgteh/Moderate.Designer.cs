namespace Orgteh
{
    partial class Moderate
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
            comboBoxMasters = new ComboBox();
            buttonModerate = new Button();
            label3 = new Label();
            textBoxMessage = new TextBox();
            labelAuthorization = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F);
            label2.Location = new Point(97, 71);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 1;
            label2.Text = "Выберите мастера:";
            // 
            // comboBoxMasters
            // 
            comboBoxMasters.BackColor = Color.FromArgb(149, 143, 143);
            comboBoxMasters.Font = new Font("Garamond", 12F);
            comboBoxMasters.FormattingEnabled = true;
            comboBoxMasters.Location = new Point(60, 93);
            comboBoxMasters.Margin = new Padding(4, 3, 4, 3);
            comboBoxMasters.Name = "comboBoxMasters";
            comboBoxMasters.Size = new Size(209, 26);
            comboBoxMasters.TabIndex = 2;
            // 
            // buttonModerate
            // 
            buttonModerate.BackColor = Color.FromArgb(149, 143, 143);
            buttonModerate.FlatStyle = FlatStyle.Flat;
            buttonModerate.Font = new Font("Garamond", 14F);
            buttonModerate.ForeColor = Color.Black;
            buttonModerate.Location = new Point(73, 253);
            buttonModerate.Margin = new Padding(4, 3, 4, 3);
            buttonModerate.Name = "buttonModerate";
            buttonModerate.Size = new Size(190, 46);
            buttonModerate.TabIndex = 3;
            buttonModerate.Text = "Обработать заявку";
            buttonModerate.UseVisualStyleBackColor = false;
            buttonModerate.Click += buttonModerate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F);
            label3.Location = new Point(85, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 18);
            label3.TabIndex = 4;
            label3.Text = "Комментарий к заявке:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.FromArgb(149, 143, 143);
            textBoxMessage.Font = new Font("Garamond", 12F);
            textBoxMessage.Location = new Point(7, 156);
            textBoxMessage.Margin = new Padding(4, 3, 4, 3);
            textBoxMessage.MaxLength = 99;
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(314, 87);
            textBoxMessage.TabIndex = 5;
            // 
            // labelAuthorization
            // 
            labelAuthorization.AutoSize = true;
            labelAuthorization.Font = new Font("Garamond", 14F);
            labelAuthorization.Location = new Point(89, 28);
            labelAuthorization.Margin = new Padding(4, 0, 4, 0);
            labelAuthorization.Name = "labelAuthorization";
            labelAuthorization.Size = new Size(151, 21);
            labelAuthorization.TabIndex = 6;
            labelAuthorization.Text = "Обработка заявки";
            // 
            // Moderate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(329, 312);
            Controls.Add(labelAuthorization);
            Controls.Add(textBoxMessage);
            Controls.Add(label3);
            Controls.Add(buttonModerate);
            Controls.Add(comboBoxMasters);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Moderate";
            Text = "Обработка новой заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMasters;
        private System.Windows.Forms.Button buttonModerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMessage;
        private Label labelAuthorization;
    }
}