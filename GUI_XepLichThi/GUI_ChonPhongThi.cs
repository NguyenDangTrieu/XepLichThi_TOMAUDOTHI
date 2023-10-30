using DAL_XepLichThi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_XepLichThi
{
	public partial class GUI_ChonPhongThi : Form
	{
		private QuanLiListPhong thi;
		private List<string> selectedItems;

		public GUI_ChonPhongThi()
		{
			InitializeComponent();
			thi = new QuanLiListPhong();
			selectedItems = new List<string>();
			InitializeCheckboxList();
		}
		public string PhongDuocChon { get; set; }


		private void InitializeCheckboxList()
		{
			int topMargin = 20;
			List<QuanLiPhong> danhSachPhong = thi.TaoDanhSachPhong();
			foreach (var phong in danhSachPhong)
			{
				CheckBox checkBox = new CheckBox();
				checkBox.Text = phong.Tenphong;
				checkBox.Top = topMargin;
				topMargin += 30;
				checkBox.CheckedChanged += CheckBox_CheckedChanged;
				panelbody.Controls.Add(checkBox);
			}
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = (CheckBox)sender;
			string item = checkBox.Text;

			if (checkBox.Checked)
			{
				// Thêm vào danh sách các phần tử đã chọn.
				selectedItems.Add(item);
			}
			else
			{
				// Loại bỏ khỏi danh sách các phần tử đã chọn.
				selectedItems.Remove(item);
			}
		}

		private void btnChapnhan_Click_1(object sender, EventArgs e)
		{
			string phongDaChon = selectedItems.FirstOrDefault();

			if (!string.IsNullOrEmpty(phongDaChon))
			{
				PhongDuocChon = phongDaChon;
				this.Close();
			}
			else
			{
				MessageBox.Show("Chưa chọn phòng.");
			}
		}

		private void btnhuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
