namespace Orgteh
{
    partial class EditRequest
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
            textBoxproblemdesc = new TextBox();
            label3 = new Label();
            comboBoxModel = new ComboBox();
            buttonSave = new Button();
            labell = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F);
            label2.Location = new Point(40, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(257, 18);
            label2.TabIndex = 7;
            label2.Text = "Редактирование описания проблемы";
            // 
            // textBoxproblemdesc
            // 
            textBoxproblemdesc.BackColor = Color.FromArgb(149, 143, 143);
            textBoxproblemdesc.Font = new Font("Garamond", 12F);
            textBoxproblemdesc.Location = new Point(6, 151);
            textBoxproblemdesc.Margin = new Padding(4, 3, 4, 3);
            textBoxproblemdesc.MaxLength = 99;
            textBoxproblemdesc.Multiline = true;
            textBoxproblemdesc.Name = "textBoxproblemdesc";
            textBoxproblemdesc.Size = new Size(322, 125);
            textBoxproblemdesc.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F);
            label3.Location = new Point(82, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 18);
            label3.TabIndex = 5;
            label3.Text = "Выберите модель техники:";
            // 
            // comboBoxModel
            // 
            comboBoxModel.BackColor = Color.FromArgb(149, 143, 143);
            comboBoxModel.Font = new Font("Garamond", 12F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(84, 85);
            comboBoxModel.Margin = new Padding(4, 3, 4, 3);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(181, 26);
            comboBoxModel.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(149, 143, 143);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Garamond", 14F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(108, 283);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(127, 46);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Garamond", 14F);
            labell.Location = new Point(11, 22);
            labell.Margin = new Padding(4, 0, 4, 0);
            labell.Name = "labell";
            labell.Size = new Size(314, 21);
            labell.TabIndex = 9;
            labell.Text = "Редактирование существующей заявки";
            // 
            // EditRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(334, 337);
            Controls.Add(labell);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(textBoxproblemdesc);
            Controls.Add(label3);
            Controls.Add(comboBoxModel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditRequest";
            Text = "Редактирование заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxproblemdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonSave;
        private Label labell;
    }
}