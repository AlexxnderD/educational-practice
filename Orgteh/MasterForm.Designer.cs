namespace Orgteh
{
    partial class MasterForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewRequest = new DataGridView();
            label1 = new Label();
            buttonReport = new Button();
            label3 = new Label();
            ExitBttn = new Button();
            labelRecordCount = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequest.Cursor = Cursors.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRequest.GridColor = Color.Black;
            dataGridViewRequest.Location = new Point(8, 50);
            dataGridViewRequest.Margin = new Padding(4, 3, 4, 3);
            dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewRequest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(149, 143, 143);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRequest.Size = new Size(1079, 550);
            dataGridViewRequest.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 4;
            label1.Text = "Добро пожаловать!";
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(149, 143, 143);
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReport.Location = new Point(321, 606);
            buttonReport.Margin = new Padding(4, 3, 4, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(453, 49);
            buttonReport.TabIndex = 5;
            buttonReport.Text = "Сформировать отчёт о выполняемых работ";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 15.75F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(469, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 11;
            label3.Text = "Активные заявки";
            // 
            // ExitBttn
            // 
            ExitBttn.BackColor = Color.FromArgb(149, 143, 143);
            ExitBttn.FlatStyle = FlatStyle.Flat;
            ExitBttn.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBttn.Location = new Point(962, 4);
            ExitBttn.Name = "ExitBttn";
            ExitBttn.Size = new Size(129, 26);
            ExitBttn.TabIndex = 10;
            ExitBttn.Text = "Вернуться назад";
            ExitBttn.UseVisualStyleBackColor = false;
            ExitBttn.Click += ExitBttn_Click;
            // 
            // labelRecordCount
            // 
            labelRecordCount.AutoSize = true;
            labelRecordCount.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRecordCount.Location = new Point(812, 637);
            labelRecordCount.Name = "labelRecordCount";
            labelRecordCount.Size = new Size(46, 18);
            labelRecordCount.TabIndex = 15;
            labelRecordCount.Text = "label3";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(149, 143, 143);
            buttonSearch.Font = new Font("Garamond", 12F);
            buttonSearch.Location = new Point(943, 608);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 25);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Найти записи";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(149, 143, 143);
            textBoxSearch.Font = new Font("Garamond", 12F);
            textBoxSearch.Location = new Point(812, 608);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 25);
            textBoxSearch.TabIndex = 13;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            ClientSize = new Size(1095, 662);
            Controls.Add(labelRecordCount);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label3);
            Controls.Add(ExitBttn);
            Controls.Add(buttonReport);
            Controls.Add(label1);
            Controls.Add(dataGridViewRequest);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MasterForm";
            Text = "Форма мастера";
            FormClosed += MasterForm_FormClosed;
            Load += MasterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport;
        private Label label3;
        private Button ExitBttn;
        private Label labelRecordCount;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}