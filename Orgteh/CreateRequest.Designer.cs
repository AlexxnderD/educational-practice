namespace Orgteh
{
    partial class CreateRequest
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
            comboBoxModel = new ComboBox();
            label1 = new Label();
            textBoxproblemdesk = new TextBox();
            label2 = new Label();
            buttonCreate = new Button();
            labell = new Label();
            SuspendLayout();
            // 
            // comboBoxModel
            // 
            comboBoxModel.BackColor = Color.FromArgb(149, 143, 143);
            comboBoxModel.FlatStyle = FlatStyle.Flat;
            comboBoxModel.Font = new Font("Garamond", 14.25F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(144, 85);
            comboBoxModel.Margin = new Padding(4, 3, 4, 3);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(170, 29);
            comboBoxModel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F);
            label1.Location = new Point(126, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 18);
            label1.TabIndex = 1;
            label1.Text = "Выберите модель техники:";
            // 
            // textBoxproblemdesk
            // 
            textBoxproblemdesk.BackColor = Color.FromArgb(149, 143, 143);
            textBoxproblemdesk.Font = new Font("Garamond", 14.25F);
            textBoxproblemdesk.Location = new Point(9, 163);
            textBoxproblemdesk.Margin = new Padding(4, 3, 4, 3);
            textBoxproblemdesk.MaxLength = 99;
            textBoxproblemdesk.Multiline = true;
            textBoxproblemdesk.Name = "textBoxproblemdesk";
            textBoxproblemdesk.Size = new Size(430, 155);
            textBoxproblemdesk.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F);
            label2.Location = new Point(74, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 18);
            label2.TabIndex = 3;
            label2.Text = "Опишите как можно подробнее проблему:";
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(149, 143, 143);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.ForeColor = Color.Black;
            buttonCreate.Location = new Point(140, 324);
            buttonCreate.Margin = new Padding(4, 3, 4, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(169, 48);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Оставить заявку";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Garamond", 14F);
            labell.Location = new Point(125, 23);
            labell.Margin = new Padding(4, 0, 4, 0);
            labell.Name = "labell";
            labell.Size = new Size(191, 21);
            labell.TabIndex = 8;
            labell.Text = "Создание новой заявки";
            // 
            // CreateRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(447, 379);
            Controls.Add(labell);
            Controls.Add(buttonCreate);
            Controls.Add(label2);
            Controls.Add(textBoxproblemdesk);
            Controls.Add(label1);
            Controls.Add(comboBoxModel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreateRequest";
            Text = "Создание новой заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxproblemdesk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreate;
        private Label labell;
    }
}