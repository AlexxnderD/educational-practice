namespace Orgteh
{
    partial class ClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewRequest = new DataGridView();
            buttoncreateRequest = new Button();
            buttonEditRequest = new Button();
            buttonDelRequest = new Button();
            label1 = new Label();
            ExitBttn = new Button();
            label2 = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            labelRecordCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequest
            // 
            dataGridViewRequest.AllowUserToAddRows = false;
            dataGridViewRequest.AllowUserToDeleteRows = false;
            dataGridViewRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRequest.BackgroundColor = Color.FromArgb(149, 143, 143);
            dataGridViewRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequest.Location = new Point(8, 60);
            dataGridViewRequest.Margin = new Padding(4, 3, 4, 3);
            dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewRequest.ReadOnly = true;
            dataGridViewRequest.Size = new Size(1076, 535);
            dataGridViewRequest.TabIndex = 2;
            // 
            // buttoncreateRequest
            // 
            buttoncreateRequest.BackColor = Color.FromArgb(149, 143, 143);
            buttoncreateRequest.FlatStyle = FlatStyle.Flat;
            buttoncreateRequest.Font = new Font("Garamond", 14F);
            buttoncreateRequest.Location = new Point(6, 601);
            buttoncreateRequest.Margin = new Padding(4, 3, 4, 3);
            buttoncreateRequest.Name = "buttoncreateRequest";
            buttoncreateRequest.Size = new Size(174, 57);
            buttoncreateRequest.TabIndex = 3;
            buttoncreateRequest.Text = "Оставить заявку";
            buttoncreateRequest.UseVisualStyleBackColor = false;
            buttoncreateRequest.Click += buttoncreateRequest_Click;
            // 
            // buttonEditRequest
            // 
            buttonEditRequest.BackColor = Color.FromArgb(149, 143, 143);
            buttonEditRequest.FlatStyle = FlatStyle.Flat;
            buttonEditRequest.Font = new Font("Garamond", 14F);
            buttonEditRequest.Location = new Point(356, 601);
            buttonEditRequest.Margin = new Padding(4, 3, 4, 3);
            buttonEditRequest.Name = "buttonEditRequest";
            buttonEditRequest.Size = new Size(259, 57);
            buttonEditRequest.TabIndex = 4;
            buttonEditRequest.Text = "Редактировать заявку";
            buttonEditRequest.UseVisualStyleBackColor = false;
            buttonEditRequest.Click += buttonEditRequest_Click;
            // 
            // buttonDelRequest
            // 
            buttonDelRequest.BackColor = Color.FromArgb(149, 143, 143);
            buttonDelRequest.FlatStyle = FlatStyle.Flat;
            buttonDelRequest.Font = new Font("Garamond", 14F);
            buttonDelRequest.Location = new Point(188, 601);
            buttonDelRequest.Margin = new Padding(4, 3, 4, 3);
            buttonDelRequest.Name = "buttonDelRequest";
            buttonDelRequest.Size = new Size(160, 57);
            buttonDelRequest.TabIndex = 5;
            buttonDelRequest.Text = "Удалить заявку";
            buttonDelRequest.UseVisualStyleBackColor = false;
            buttonDelRequest.Click += buttonDelRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать!";
            // 
            // ExitBttn
            // 
            ExitBttn.BackColor = Color.FromArgb(149, 143, 143);
            ExitBttn.FlatStyle = FlatStyle.Flat;
            ExitBttn.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBttn.Location = new Point(960, 3);
            ExitBttn.Name = "ExitBttn";
            ExitBttn.Size = new Size(129, 26);
            ExitBttn.TabIndex = 8;
            ExitBttn.Text = "Вернуться назад";
            ExitBttn.UseVisualStyleBackColor = false;
            ExitBttn.Click += ExitBttn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 15.75F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(446, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(207, 24);
            label2.TabIndex = 9;
            label2.Text = "История ваших заявок";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(149, 143, 143);
            textBoxSearch.Font = new Font("Garamond", 12F);
            textBoxSearch.Location = new Point(727, 606);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 25);
            textBoxSearch.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(149, 143, 143);
            buttonSearch.Font = new Font("Garamond", 12F);
            buttonSearch.Location = new Point(858, 606);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 25);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Найти записи";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelRecordCount
            // 
            labelRecordCount.AutoSize = true;
            labelRecordCount.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRecordCount.Location = new Point(727, 635);
            labelRecordCount.Name = "labelRecordCount";
            labelRecordCount.Size = new Size(46, 18);
            labelRecordCount.TabIndex = 12;
            labelRecordCount.Text = "label3";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(1091, 664);
            Controls.Add(labelRecordCount);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label2);
            Controls.Add(ExitBttn);
            Controls.Add(buttonDelRequest);
            Controls.Add(buttonEditRequest);
            Controls.Add(buttoncreateRequest);
            Controls.Add(dataGridViewRequest);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ClientForm";
            Text = "Форма клиентов";
            FormClosed += ClientForm_FormClosed;
            Load += ClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Button buttoncreateRequest;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonDelRequest;
        private Label label1;
        private Button ExitBttn;
        private Label label2;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label labelRecordCount;
    }
}