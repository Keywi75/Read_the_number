using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private string DocSo(long number)
        {
            if (number == 0) return "Không";
            if (number < 0) return "Âm " + DocSo(-number);

            string[] donVi = { "", "nghìn", "triệu", "tỷ" };
            string result = "";
            int index = 0;
            bool coNghin = false; // Kiểm tra có hàng nghìn hay không

            while (number > 0)
            {
                int baSo = (int)(number % 1000);
                number /= 1000;

                if (baSo > 0)
                {
                    string strBaSo = DocBaSo(baSo);

                    if (!string.IsNullOrEmpty(strBaSo))
                    {
                        // Kiểm tra nếu đã có "nghìn" trước đó để tránh lặp "lẻ"
                        if (index == 1) coNghin = true;

                        result = strBaSo + (index > 0 ? " " + donVi[index] : "") + " " + result;
                    }
                }
                index++;
            }

            // Xử lý trường hợp "lẻ" không cần thiết
            if (result.StartsWith("lẻ "))
                result = result.Substring(2); // Xóa từ "lẻ "

            return result.Trim();

        }

        // Đọc từng nhóm ba chữ số
        private string DocBaSo(int number)
        {
            if (number == 0) return "";

            string[] chuSo = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string result = "";
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donvi = number % 10;

            if (tram > 0)
                result += chuSo[tram] + " trăm ";

            if (chuc > 1)
                result += chuSo[chuc] + " mươi ";
            else if (chuc == 1)
                result += "mười ";

            if (donvi > 0)
            {
                if (chuc == 0 && tram > 0) // TH 203, 507 -> "lẻ ba"
                    result += "lẻ " + chuSo[donvi];
                else if (chuc == 0 && tram == 0) // TH 2003, 3006 -> "hai nghìn lẻ ba"
                    result += "lẻ " + chuSo[donvi];
                else if (chuc == 1 && donvi == 5)
                    result += "lăm";
                else if (chuc > 1 && donvi == 5)
                    result += "lăm";
                else if (chuc >= 1 && donvi == 1)
                    result += "mốt";
                else
                    result += chuSo[donvi];
            }

            return result.Trim();
        }


        // Sự kiện khi nhấn button "Doc"
        private void Doc_Click(object sender, EventArgs e)
        {
            if (long.TryParse(nhapso.Text, out long num))
            {
                ketqua.Text = DocSo(num);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn button "Xoa"
        private void Xoa_Click(object sender, EventArgs e)
        {
            nhapso.Clear();
            ketqua.Clear();
            nhapso.Focus();
        }

        // Sự kiện khi nhấn button "Thoat"
        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhapso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
