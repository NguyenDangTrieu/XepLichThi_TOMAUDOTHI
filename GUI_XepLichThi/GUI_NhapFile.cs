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
	public partial class GUI_NhapFile : Form
	{
		public GUI_NhapFile()
		{
			InitializeComponent();
		}
		public void PopulateDataGridView(List<object[]> data)
		{
			dataGridView_NhapDuLieu.Rows.Clear();
			foreach (var row in data)
			{
				dataGridView_NhapDuLieu.Rows.Add(row);
			}
		}

		private void dataGridView_NhapDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void chọnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void dataGridView_NhapDuLieu_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{

			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridView_NhapDuLieu.Rows[e.RowIndex];
				GUI_ChonPhongThi formChonPhong = new GUI_ChonPhongThi();
				formChonPhong.ShowDialog();
				string phongDaChon = formChonPhong.PhongDuocChon;
				if (!string.IsNullOrEmpty(phongDaChon))
				{
					selectedRow.Cells["Column10"].Value = phongDaChon;
				}
			}
		}
		public List<string> LayDanhSachPhongDaXep()
		{
			List<string> danhSachPhongDaXep = new List<string>();

			foreach (DataGridViewRow row in dataGridView_NhapDuLieu.Rows)
			{
				if (row.Cells["Column10"].Value != null)
				{
					string phongDaXep = row.Cells["Column10"].Value.ToString();
					danhSachPhongDaXep.Add(phongDaXep);
				}
			}

			return danhSachPhongDaXep;
		}
		public void ScheduleAndFillData(List<ScheduleColoringAlgorithm.ExamSlot> examSlots)
		{
			// Sử dụng thuật toán để xếp lịch
			ScheduleColoringAlgorithm scheduler = new ScheduleColoringAlgorithm();
			scheduler.ExamSlots = examSlots;
			scheduler.ColorExams();

			// Duyệt qua từng dòng trong DataGridView
			foreach (DataGridViewRow row in dataGridView_NhapDuLieu.Rows)
			{
				// Kiểm tra nếu còn các môn thi trong danh sách
				if (examSlots.Count > 0 && row.Cells["Column10"].Value != null)
				{
					// Lấy môn thi đầu tiên từ danh sách
					var exam = examSlots[0];
					string nt = exam.ExamDate.ToString("yyyyMMdd");
					string gt = exam.ExamTime;
					string key = nt + gt;
					string formattedDate = exam.ExamDate.ToString("dd/MM/yyyy");
					// Kiểm tra xem môn thi này có thể xếp lịch
					if (scheduler.RoomOccupancy.ContainsKey(key))
					{
						Color color = scheduler.RoomOccupancy[key];

						// Gán giá trị ngày thi và giờ thi cho dòng hiện tại
						row.Cells["NgayThi"].Value = formattedDate;
						row.Cells["GioThi"].Value = gt;

						// Loại bỏ môn thi đã xếp lịch khỏi danh sách
						examSlots.RemoveAt(0);
					}
				}
				else
				{
					// Nếu không còn môn thi nào trong danh sách hoặc chưa chọn phòng thi, tô màu đỏ.
					row.DefaultCellStyle.BackColor = Color.Red;
				}
			}
		}
		public DataGridView GetDataGridView()
		{
			return dataGridView_NhapDuLieu; // Thay thế bằng tên DataGridView thực tế của bạn
		}




	}
}
