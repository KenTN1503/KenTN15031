using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lap_Giuaki.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lap_Giuaki
{
    public partial class frmsinhvien : Form
    {
        QuanLySVEntities nguyen = new QuanLySVEntities();
        public frmsinhvien()
        {
            InitializeComponent();
        }
        private void frmsinhvien_Load(object sender, EventArgs e)
        {
            load();
     
        }

        public void load()
        {

            var N = nguyen.SinhViens.ToList();
            dgvsinhvien.DataSource = N;
            var Lopslist = nguyen.Lops.ToList();
            cmbkhoa.DataSource = Lopslist;
            cmbkhoa.DisplayMember = "Lớp";
            cmbkhoa.ValueMember = "TenLop";
        }
        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsinhvien_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cmbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (string.IsNullOrWhiteSpace(txtmsv.Text) ||
                string.IsNullOrWhiteSpace(txthoten.Text) ||
                cmbkhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo mới sinh viên và thêm vào cơ sở dữ liệu
            var newStudent = new SinhVien
            {
                MaSV = txtmsv.Text,
                HoTenSV = txthoten.Text,
                NgaySinh = dtpngaysinh.Value,
                MaLop = cmbkhoa.SelectedValue.ToString() // Lấy giá trị từ ComboBox
            };

            // Thêm sinh viên vào danh sách
            nguyen.SinhViens.Add(newStudent);

            try
            {
                nguyen.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                load(); // Tải lại danh sách sinh viên
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng hàng được nhấp là hàng hợp lệ
            {
                // Lấy sản phẩm từ hàng đã chọn
                var selectedRow = dgvsinhvien.Rows[e.RowIndex];

                // Gán giá trị cho các trường nhập liệu
                txtmsv.Text = selectedRow.Cells["MaSV"].Value.ToString(); // Giả sử tên cột là "MaSP"
                txthoten.Text = selectedRow.Cells["HoTenSV"].Value.ToString(); // Giả sử tên cột là "TenSP"
                dtpngaysinh.Value = (DateTime)selectedRow.Cells["NgaySinh"].Value; // Giả sử tên cột là "NgayNhap"
                var MaLop = selectedRow.Cells["MaLop"].Value.ToString(); // Giả sử tên cột là "MaLop"
                cmbkhoa.SelectedValue = MaLop; // Đặt giá trị đã chọn cho ComboBox
            }
        }
        private void btnfix_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có sinh viên nào được chọn
            if (dgvsinhvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            // Lấy hàng đã chọn
            var selectedRow = dgvsinhvien.SelectedRows[0];

            // Cập nhật thông tin sinh viên
            string maSV = selectedRow.Cells["MaSV"].Value.ToString(); // Giả sử tên cột là "MaSV"
            var studentToUpdate = nguyen.SinhViens.FirstOrDefault(s => s.MaSV == maSV);

            if (studentToUpdate != null)
            {
                studentToUpdate.HoTenSV = txthoten.Text;
                studentToUpdate.NgaySinh = dtpngaysinh.Value;
                studentToUpdate.MaLop = cmbkhoa.SelectedValue.ToString(); // Lấy giá trị từ ComboBox

                nguyen.SaveChanges();
                load();
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên để cập nhật.");
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form
            }
            // Nếu người dùng chọn No, không làm gì cả
        }
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (string.IsNullOrWhiteSpace(txtmsv.Text) ||
                string.IsNullOrWhiteSpace(txthoten.Text) ||
                cmbkhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã sinh viên đã tồn tại chưa
            var existingStudent = nguyen.SinhViens.FirstOrDefault(s => s.MaSV == txtmsv.Text);
            if (existingStudent != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo mới sinh viên và thêm vào cơ sở dữ liệu
            var newStudent = new SinhVien
            {
                MaSV = txtmsv.Text,
                HoTenSV = txthoten.Text,
                NgaySinh = dtpngaysinh.Value,
                MaLop = cmbkhoa.SelectedValue.ToString() // Lấy giá trị từ ComboBox
            };

            // Thêm sinh viên vào danh sách
            nguyen.SinhViens.Add(newStudent);

            try
            {
                nguyen.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                load(); // Tải lại danh sách sinh viên
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có sinh viên nào được chọn
            if (dgvsinhvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Nếu người dùng chọn No, thoát phương thức
            }

            // Lấy mã sinh viên đã chọn
            var selectedRow = dgvsinhvien.SelectedRows[0];
            string maSV = selectedRow.Cells["MaSV"].Value.ToString(); // Giả sử tên cột là "MaSV"

            // Tìm sinh viên trong cơ sở dữ liệu
            var studentToDelete = nguyen.SinhViens.FirstOrDefault(s => s.MaSV == maSV);

            if (studentToDelete != null)
            {
                // Xóa sinh viên
                nguyen.SinhViens.Remove(studentToDelete);
                try
                {
                    nguyen.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    load(); // Tải lại danh sách sinh viên
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txttimkiem.Text.Trim(); // Giả sử bạn có một TextBox để nhập từ khóa tìm kiếm

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Nếu TextBox trống, tải lại tất cả sinh viên
                load(); // Gọi hàm load() để hiển thị tất cả sinh viên
                return;
            }

            // Tìm kiếm sinh viên theo MaSV hoặc HoTenSV
            var results = nguyen.SinhViens
                            .Where(s => s.MaSV.Contains(searchTerm) || s.HoTenSV.Contains(searchTerm))
                            .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Hiển thị kết quả tìm kiếm trong DataGridView
            dgvsinhvien.DataSource = results;
        }
    }
}