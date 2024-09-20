namespace Orgteh
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            dataGridViewRequest = new DataGridView();
            buttondismiss = new Button();
            buttonaccept = new Button();
            label1 = new Label();
            ExitBttn = new Button();
            label2 = new Label();
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
            dataGridViewRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dataGridViewRequest, "dataGridViewRequest");
            dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewRequest.ReadOnly = true;
            // 
            // buttondismiss
            // 
            buttondismiss.BackColor = Color.FromArgb(149, 143, 143);
            resources.ApplyResources(buttondismiss, "buttondismiss");
            buttondismiss.Name = "buttondismiss";
            buttondismiss.UseVisualStyleBackColor = false;
            buttondismiss.Click += buttondismiss_Click;
            // 
            // buttonaccept
            // 
            buttonaccept.BackColor = Color.FromArgb(149, 143, 143);
            resources.ApplyResources(buttonaccept, "buttonaccept");
            buttonaccept.Name = "buttonaccept";
            buttonaccept.UseVisualStyleBackColor = false;
            buttonaccept.Click += buttonaccept_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // ExitBttn
            // 
            ExitBttn.BackColor = Color.FromArgb(149, 143, 143);
            resources.ApplyResources(ExitBttn, "ExitBttn");
            ExitBttn.Name = "ExitBttn";
            ExitBttn.UseVisualStyleBackColor = false;
            ExitBttn.Click += ExitBttn_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // labelRecordCount
            // 
            resources.ApplyResources(labelRecordCount, "labelRecordCount");
            labelRecordCount.Name = "labelRecordCount";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(149, 143, 143);
            resources.ApplyResources(buttonSearch, "buttonSearch");
            buttonSearch.Name = "buttonSearch";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(149, 143, 143);
            resources.ApplyResources(textBoxSearch, "textBoxSearch");
            textBoxSearch.Name = "textBoxSearch";
            // 
            // OperatorForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 165, 166);
            Controls.Add(labelRecordCount);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label2);
            Controls.Add(ExitBttn);
            Controls.Add(buttonaccept);
            Controls.Add(buttondismiss);
            Controls.Add(label1);
            Controls.Add(dataGridViewRequest);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OperatorForm";
            FormClosed += OperatorForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Button buttondismiss;
        private System.Windows.Forms.Button buttonaccept;
        private Label label1;
        private Button ExitBttn;
        private Label label2;
        private Label labelRecordCount;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}