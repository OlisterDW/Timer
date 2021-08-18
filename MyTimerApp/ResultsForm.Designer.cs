
namespace MyTimerApp
{
    partial class ResultsForm
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
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.clearResultsButton = new System.Windows.Forms.Button();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.ResultColumn,
            this.DataColumn});
            this.ResultDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.Size = new System.Drawing.Size(383, 247);
            this.ResultDataGridView.TabIndex = 0;
            // 
            // clearResultsButton
            // 
            this.clearResultsButton.Location = new System.Drawing.Point(12, 255);
            this.clearResultsButton.Name = "clearResultsButton";
            this.clearResultsButton.Size = new System.Drawing.Size(105, 40);
            this.clearResultsButton.TabIndex = 1;
            this.clearResultsButton.Text = "Очистить список";
            this.clearResultsButton.UseVisualStyleBackColor = true;
            this.clearResultsButton.Click += new System.EventHandler(this.clearResultsButton_Click);
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Номер";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Width = 60;
            // 
            // ResultColumn
            // 
            this.ResultColumn.HeaderText = "Результат";
            this.ResultColumn.Name = "ResultColumn";
            this.ResultColumn.ReadOnly = true;
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Дата";
            this.DataColumn.Name = "DataColumn";
            this.DataColumn.ReadOnly = true;
            this.DataColumn.Width = 180;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(248, 255);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 40);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 302);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.clearResultsButton);
            this.Controls.Add(this.ResultDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Предыдущие результаты";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.Button clearResultsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumn;
        private System.Windows.Forms.Button CloseButton;
    }
}