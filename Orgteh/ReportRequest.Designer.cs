namespace Orgteh
{
    partial class ReportRequest
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
            textBox1 = new TextBox();
            buttonReport = new Button();
            labell = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(35, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 18);
            label2.TabIndex = 1;
            label2.Text = "Укажите какие запчасти были использованы:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(149, 143, 143);
            textBox1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 75);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.MaxLength = 99;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 116);
            textBox1.TabIndex = 2;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(149, 143, 143);
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReport.ForeColor = Color.Black;
            buttonReport.Location = new Point(96, 200);
            buttonReport.Margin = new Padding(4, 3, 4, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(191, 48);
            buttonReport.TabIndex = 3;
            buttonReport.Text = "Подтвердить отчёт";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Garamond", 14F);
            labell.Location = new Point(33, 18);
            labell.Margin = new Padding(4, 0, 4, 0);
            labell.Name = "labell";
            labell.Size = new Size(319, 21);
            labell.TabIndex = 7;
            labell.Text = "Создание отчёта о выполняемых работ";
            // 
            // ReportRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(383, 259);
            Controls.Add(labell);
            Controls.Add(buttonReport);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReportRequest";
            Text = "Создание отчёта заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonReport;
        private Label labell;
    }
}