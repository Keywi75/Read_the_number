using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex5: Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void nhap(object sender, EventArgs e)
        {

        }

        private void Xuat(object sender, EventArgs e)
        {
            {
                // Lấy dữ liệu từ textbox
                string inputText = input.Text.Trim();

                // Kiểm tra và chuyển đổi dữ liệu thành danh sách số thực
                string[] items = inputText.Split(' ');
                double[] scores;
                try
                {
                    scores = items.Select(x => double.Parse(x)).ToArray();

                    // Kiểm tra xem tất cả giá trị có nằm trong khoảng 0 - 10 không
                    if (scores.Any(x => x < 0 || x > 10))
                    {
                        MessageBox.Show("Dữ liệu nhập phải trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StringBuilder sb = new StringBuilder();
                int half = (scores.Length + 1) / 2; // Chia đôi danh sách điểm

                for (int i = 0; i < half; i++)
                {
                    string leftCol = $"Môn {i + 1}: {scores[i]}";
                    string rightCol = (i + half < scores.Length) ? $"Môn {i + half + 1}: {scores[i + half]}" : "";
                    sb.AppendLine($"{leftCol,-15} {rightCol}"); // Căn chỉnh khoảng cách giữa 2 cột
                }

                Hien_thi.Text = sb.ToString();

                // Tính toán các giá trị cần thiết
                double TB = scores.Average();
                double Lon_nhat = scores.Max();
                double Nho_nhat = scores.Min();
                int mon_dau = scores.Count(x => x >= 5);
                int mon_rot = scores.Count(x => x < 5);

                // Xếp loại sinh viên
                string xeploai;
                if (TB >= 8 && scores.All(x => x >= 6.5)) xeploai = "Giỏi";
                else if (TB >= 6.5 && scores.All(x => x >= 5)) xeploai = "Khá";
                else if (TB >= 5 && scores.All(x => x >= 3.5)) xeploai = "Trung bình";
                else if (TB >= 3.5 && scores.All(x => x >= 2)) xeploai = "Yếu";
                else xeploai = "Kém";

                // Hiển thị kết quả
                
                label4.Text = $"Điểm TB: {TB:F2}";
                label5.Text = $"Điểm cao nhất: {Lon_nhat}";
                label7.Text = $"Điểm thấp nhất: {Nho_nhat}";
                label6.Text = $"Số môn đậu: {mon_dau}";
                label8.Text = $"Số môn không đậu: {mon_rot}";
                label9.Text = $"Xếp loại: {xeploai}";

            }
        }   

        private void HienT(object sender, EventArgs e)
        {

        }

        private void Tinhtoan(object sender, EventArgs e)
        {

        }
    }
}
