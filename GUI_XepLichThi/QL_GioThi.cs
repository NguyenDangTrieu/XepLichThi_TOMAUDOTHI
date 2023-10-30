using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_XepLichThi;

namespace GUI_XepLichThi
{
	public partial class QL_GioThi : Form
	{
		private List<LessonSchedule> lichHoc;

		public QL_GioThi()
		{
			InitializeComponent();
		}

		private void btnlayngay_Click(object sender, EventArgs e)
		{
			DateTime ngayBatDau = dateTimePickerngaybatdau.Value.Date;
			DateTime ngayKetThuc = dateTimePickerNgayketthuc.Value.Date;
			List<string> danhSachGioBatDau = new List<string>
			{
				"7:00",
				"9:00",
				"13:00",
				"16:00"
			};

			// Sử dụng biến instance lichHoc
			lichHoc = new List<LessonSchedule>();

			for (DateTime date = ngayBatDau; date <= ngayKetThuc; date = date.AddDays(1))
			{
				foreach (string gioBatDau in danhSachGioBatDau)
				{
					DateTime startTime = DateTime.Parse(gioBatDau);
					String startDateTime = startTime.TimeOfDay.ToString();

					lichHoc.Add(new LessonSchedule
					{
						Ngay = date,
						GioBatDau = startDateTime
					});
				}
			}
			dataGridViewGioThi.DataSource = lichHoc;
		}

		private void QL_GioThi_Load(object sender, EventArgs e)
		{
			CreateAndPopulateDataGridView();
		}

		private void CreateAndPopulateDataGridView()
		{
			// Thêm cột nút "Xóa" vào DataGridView
			DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
			buttonColumn.HeaderText = "Xóa";
			buttonColumn.Text = "Xóa";
			buttonColumn.Name = "Xoa"; // Đặt tên cho cột nút "Xóa"
			buttonColumn.UseColumnTextForButtonValue = true;
			dataGridViewGioThi.Columns.Add(buttonColumn);

			// Đăng ký sự kiện CellContentClick cho DataGridView
			dataGridViewGioThi.CellContentClick += dataGridViewGioThi_CellContentClick;
		}

		private void dataGridViewGioThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridViewGioThi.Columns["Xoa"].Index && e.RowIndex >= 0 && e.RowIndex < lichHoc.Count)
			{
				// Kiểm tra xem chỉ mục hợp lệ trước khi xóa
				int rowIndex = e.RowIndex;

				// Xóa dòng tại chỉ mục rowIndex
				lichHoc.RemoveAt(rowIndex);

				// Cập nhật DataGridView
				dataGridViewGioThi.DataSource = null;
				dataGridViewGioThi.DataSource = lichHoc;
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Giờ Thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		public List<DAL_QuanLiNgay> DanhSachLichThi { get; set; } = new List<DAL_QuanLiNgay>();

		private void btnluu_Click(object sender, EventArgs e)
		{
			if (lichHoc != null && lichHoc.Count > 0)
			{
				foreach (LessonSchedule lesson in lichHoc)
				{
					DanhSachLichThi.Add(new DAL_QuanLiNgay
					{
						Ngay = lesson.Ngay,
						GioThi = lesson.GioBatDau
					});
				}

				// Gửi danh sách lịch học sang form TrangChu
				TrangChu trangChuForm = Application.OpenForms.OfType<TrangChu>().FirstOrDefault();
				if (trangChuForm != null)
				{
					trangChuForm.LichHoc = DanhSachLichThi;

					MessageBox.Show("Lưu Thành Công!");
				}



				this.Close();
			}
			else
			{
				MessageBox.Show("Danh sách lịch thi trống. Hãy nhập lịch thi trước khi lưu.");
			}
		}
	}
}
