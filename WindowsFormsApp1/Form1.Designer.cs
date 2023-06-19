namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.txtBurstTime = new System.Windows.Forms.TextBox();
            this.txtAverageTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompletionTime = new System.Windows.Forms.TextBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewProcess = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên tiến trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "thời gian tiến trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "thời gian xuất hiện";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(128, 24);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(76, 20);
            this.txtProcessName.TabIndex = 1;
            // 
            // txtBurstTime
            // 
            this.txtBurstTime.Location = new System.Drawing.Point(128, 48);
            this.txtBurstTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBurstTime.Name = "txtBurstTime";
            this.txtBurstTime.Size = new System.Drawing.Size(76, 20);
            this.txtBurstTime.TabIndex = 2;
            // 
            // txtAverageTime
            // 
            this.txtAverageTime.Location = new System.Drawing.Point(128, 75);
            this.txtAverageTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAverageTime.Name = "txtAverageTime";
            this.txtAverageTime.Size = new System.Drawing.Size(76, 20);
            this.txtAverageTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "thời gian hoàn thành";
            // 
            // txtCompletionTime
            // 
            this.txtCompletionTime.Location = new System.Drawing.Point(371, 28);
            this.txtCompletionTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompletionTime.Name = "txtCompletionTime";
            this.txtCompletionTime.ReadOnly = true;
            this.txtCompletionTime.Size = new System.Drawing.Size(84, 20);
            this.txtCompletionTime.TabIndex = 10;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.BackColor = System.Drawing.Color.Thistle;
            this.btnAddProcess.ForeColor = System.Drawing.Color.Red;
            this.btnAddProcess.Location = new System.Drawing.Point(34, 117);
            this.btnAddProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(56, 31);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.Text = "thêm";
            this.btnAddProcess.UseVisualStyleBackColor = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Thistle;
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(128, 117);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 31);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "chạy";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Thistle;
            this.BtnReset.ForeColor = System.Drawing.Color.Red;
            this.BtnReset.Location = new System.Drawing.Point(228, 117);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(56, 31);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(330, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Location = new System.Drawing.Point(34, 162);
            this.dataGridViewProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.RowHeadersWidth = 51;
            this.dataGridViewProcess.RowTemplate.Height = 24;
            this.dataGridViewProcess.Size = new System.Drawing.Size(524, 176);
            this.dataGridViewProcess.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewProcess);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.txtCompletionTime);
            this.Controls.Add(this.txtAverageTime);
            this.Controls.Add(this.txtBurstTime);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.TextBox txtBurstTime;
        private System.Windows.Forms.TextBox txtAverageTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompletionTime;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewProcess;
    }
}

