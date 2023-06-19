using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Queue<Process> processQueue; // Hàng đợi tiến trình
        private List<Process> completedProcesses; // Danh sách tiến trình đã hoàn thành

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            processQueue = new Queue<Process>();
            completedProcesses = new List<Process>();
        }

        private void InitializeDataGridView()
        {
            // Tạo các cột trong DataGridView
            DataGridViewTextBoxColumn colProcessName = new DataGridViewTextBoxColumn();
            colProcessName.HeaderText = "Tên tiến trình";
            colProcessName.Name = "colProcessName";

            DataGridViewTextBoxColumn colBurstTime = new DataGridViewTextBoxColumn();
            colBurstTime.HeaderText = "Thời gian thực thi";
            colBurstTime.Name = "colBurstTime";

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.HeaderText = "Trạng thái";
            colStatus.Name = "colStatus";

            DataGridViewTextBoxColumn colTurnaroundTime = new DataGridViewTextBoxColumn();
            colTurnaroundTime.HeaderText = "Thời gian tồn tại";
            colTurnaroundTime.Name = "colTurnaroundTime";

            DataGridViewTextBoxColumn colTurnaroundTimeAvg = new DataGridViewTextBoxColumn();
            colTurnaroundTimeAvg.HeaderText = "Thời gian tồn tại trung bình";
            colTurnaroundTimeAvg.Name = "colTurnaroundTimeAvg";

            // Thêm các cột vào DataGridView
            dataGridViewProcess.Columns.Add(colProcessName);
            dataGridViewProcess.Columns.Add(colBurstTime);
            dataGridViewProcess.Columns.Add(colStatus);
            dataGridViewProcess.Columns.Add(colTurnaroundTime);
            dataGridViewProcess.Columns.Add(colTurnaroundTimeAvg);

            // Đăng ký sự kiện CellFormatting
            dataGridViewProcess.CellFormatting += DataGridViewProcess_CellFormatting;
        }

        private void DataGridViewProcess_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột trạng thái
            if (dataGridViewProcess.Columns[e.ColumnIndex].Name == "colStatus")
            {
                // Lấy giá trị của ô cột trạng thái
                string status = e.Value?.ToString();

                // Thiết lập màu nền dựa trên giá trị trạng thái
                if (status == "Đang chạy")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (status == "Hoàn thành")
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else if (status == "Chờ chạy")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }





        private void CapNhatTrangThaiTienTrinh(string processName, string status)
        {
            foreach (DataGridViewRow row in dataGridViewProcess.Rows)
            {
                if (row.Cells["colProcessName"].Value?.ToString() == processName)
                {
                    int statusColumnIndex = dataGridViewProcess.Columns["colStatus"].Index;

                    // Kiểm tra giá trị chỉ số cột
                    if (statusColumnIndex >= 0 && statusColumnIndex < dataGridViewProcess.Columns.Count)
                    {
                        row.Cells[statusColumnIndex].Value = status;
                    }
                    else
                    {
                        // Xử lý lỗi ở đây (nếu có)
                    }

                    break;
                }
            }
        }
        int completionTime = 0;
        private void CapNhatDanhSachTienTrinh()
        {
             // Tổng thời gian hoàn thành
            



            foreach (Process process in completedProcesses)
            {
                foreach (DataGridViewRow row in dataGridViewProcess.Rows)
                {
                    if (row.Cells["colProcessName"].Value?.ToString() == process.Name)
                    {
                        int turnaroundTimeColumnIndex = dataGridViewProcess.Columns["colTurnaroundTime"].Index;

                        // Kiểm tra giá trị chỉ số cột
                        if (turnaroundTimeColumnIndex >= 0 && turnaroundTimeColumnIndex < dataGridViewProcess.Columns.Count)
                        {
                            row.Cells[turnaroundTimeColumnIndex].Value = process.TurnaroundTime.ToString();
                        }
                        else
                        {
                            // Xử lý lỗi ở đây (nếu có)
                        }
                        
                        

                        break;
                    }
                    
                }
                completionTime = Math.Max(completionTime, process.TurnaroundTime);
            }
            
            
            // Tính thời gian tồn tại trung bình mỗi tiến trình và hiển thị trên DataGridView
            double averageTurnaroundTime = completedProcesses.Average(p => p.TurnaroundTime);

            int averageTurnaroundTimeColumnIndex = dataGridViewProcess.Columns["colTurnaroundTimeAvg"].Index;

            // Kiểm tra giá trị chỉ số cột
            if (averageTurnaroundTimeColumnIndex >= 0 && averageTurnaroundTimeColumnIndex < dataGridViewProcess.Columns.Count)
            {
                foreach (DataGridViewRow row in dataGridViewProcess.Rows)
                {
                    row.Cells[averageTurnaroundTimeColumnIndex].Value = averageTurnaroundTime.ToString("0.00");
                }
            }
            else
            {
                // Xử lý lỗi ở đây (nếu có)
            }
            
        }

        private void btnAddProcess_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtProcessName.Text) || string.IsNullOrWhiteSpace(txtBurstTime.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tiến trình và thời gian thực thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string processName = txtProcessName.Text;
            int burstTime = Convert.ToInt32(txtBurstTime.Text);

            // Tạo một tiến trình mới
            Process process = new Process(processName, burstTime);

            // Thêm tiến trình vào hàng đợi
            processQueue.Enqueue(process);

            // Thêm tiến trình vào DataGridView
            dataGridViewProcess.Rows.Add(processName, burstTime, "", "");

            // Xóa các trường đầu vào
            txtProcessName.Text = "";
            txtBurstTime.Text = "";
            txtAverageTime.Text = "";
        }

        private async void btnStart_Click_1(object sender, EventArgs e)
        {
            int totalBurstTime = 0; // Tổng thời gian thực thi của các tiến trình
            int totalProcesses = dataGridViewProcess.Rows.Count; // Tổng số tiến trình
            
            while (processQueue.Count > 0)
            {
                Process currentProcess = processQueue.Dequeue();

                // Cập nhật trạng thái tiến trình
                CapNhatTrangThaiTienTrinh(currentProcess.Name, "Đang chạy");

                // Giả lập thực thi tiến trình
                await Task.Delay(currentProcess.BurstTime * 1000);

                // Cập nhật trạng thái tiến trình
                CapNhatTrangThaiTienTrinh(currentProcess.Name, "Hoàn thành");

                // Tính thời gian tồn tại của tiến trình
                currentProcess.TurnaroundTime = totalBurstTime + currentProcess.BurstTime;

                // Thêm tiến trình đã hoàn thành vào danh sách
                completedProcesses.Add(currentProcess);

                // Cập nhật danh sách tiến trình
                CapNhatDanhSachTienTrinh();
                // Hiển thị thời gian hoàn thành trên TextBox
                
                totalBurstTime += currentProcess.BurstTime;
            }
            // Tính thời gian hoàn thành
            

            txtCompletionTime.Text = completionTime.ToString();


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            processQueue.Clear();
            completedProcesses.Clear();
            dataGridViewProcess.Rows.Clear();
            txtCompletionTime.Text = "";
            txtAverageTime.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // Lớp Process đại diện cho một tiến trình
    public class Process
    {
        public string Name { get; set; } // Tên tiến trình
        public int BurstTime { get; set; } // Thời gian thực thi
        public int TurnaroundTime { get; set; } // Thời gian tồn tại

        public Process(string name, int burstTime)
        {
            Name = name;
            BurstTime = burstTime;
            TurnaroundTime = 0;
        }
    }
}
