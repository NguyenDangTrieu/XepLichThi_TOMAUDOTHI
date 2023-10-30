using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using DAL_XepLichThi;

namespace GUI_XepLichThi
{
	public partial class TrangChu : Form
	{
		private Form currentFormChild;

		public TrangChu()
		{
			InitializeComponent();
		}

		private List<object[]> ReadExcel(string filePath)
		{
			List<object[]> excelData = new List<object[]>();

			FileInfo fileInfo = new FileInfo(filePath);
			using (ExcelPackage package = new ExcelPackage(fileInfo))
			{
				ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

				int rowCount = worksheet.Dimension.Rows;
				int colCount = worksheet.Dimension.Columns;

				for (int row = 2; row <= rowCount; row++)
				{
					object[] rowData = new object[colCount];
					for (int col = 1; col <= colCount; col++)
					{
						rowData[col - 1] = worksheet.Cells[row, col].Value;
					}
					excelData.Add(rowData);
				}
			}

			return excelData;
		}

		private void nhậpFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					try
					{
						List<object[]> excelData = ReadExcel(filePath);

						GUI_NhapFile guiNhapFileForm = new GUI_NhapFile();
						guiNhapFileForm.PopulateDataGridView(excelData);

						OpenFormChild(guiNhapFileForm);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi đọc tệp Excel: " + ex.Message);
					}
				}
			}
		}

		private void OpenFormChild(Form formChild)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			currentFormChild = formChild;
			formChild.TopLevel = false;
			formChild.FormBorderStyle = FormBorderStyle.None;
			formChild.Dock = DockStyle.Fill;
			panel_body.Controls.Add(formChild);
			panel_body.Tag = formChild;
			formChild.BringToFront();
			formChild.Show();
		}

		private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
		}

		private void quảnLíGiờThiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QL_GioThi qlGioThi = new QL_GioThi();
			qlGioThi.Show();
		}
		public List<DAL_QuanLiNgay> LichHoc { get; internal set; }
		private void ShowScheduledExams(List<ScheduleColoringAlgorithm.ExamSlot> scheduledExams)
		{
			if (scheduledExams != null && scheduledExams.Count > 0)
			{
				string scheduleText = "Lịch học đã xếp:\n";

				foreach (var exam in scheduledExams)
				{
					scheduleText += $"Ngày thi: {exam.ExamDate:dd/MM/yyyy}, Giờ thi: {exam.ExamTime}\n";
				}

				MessageBox.Show(scheduleText, "Lịch học đã xếp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Chưa xếp lịch cho bất kỳ kỳ thi nào.", "Lịch học rỗng", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void sắpXếpLịchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null && currentFormChild is GUI_NhapFile guiNhapFileForm)
			{
				if (LichHoc != null && LichHoc.Count > 0)
				{
					var scheduledExams = LichHoc.Select(item => new ScheduleColoringAlgorithm.ExamSlot
					{
						ExamDate = item.Ngay,
						ExamTime = item.GioThi
					}).ToList();

					guiNhapFileForm.ScheduleAndFillData(scheduledExams);
				}
				else
				{
					MessageBox.Show("Danh sách lịch thi trống. Hãy nhập lịch thi trước khi sắp xếp.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng mở form nhập dữ liệu lịch thi trước.");
			}
		}

		private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataGridView dataGridViewFromOtherForm = ((GUI_NhapFile)currentFormChild).GetDataGridView();
			if (currentFormChild != null && currentFormChild is GUI_NhapFile guiNhapFileForm)
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
					saveFileDialog.FilterIndex = 1;
					saveFileDialog.RestoreDirectory = true;

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						string filePath = saveFileDialog.FileName;

						try
						{
							using (ExcelPackage package = new ExcelPackage())
							{
								ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");
								for (int i = 0; i < dataGridViewFromOtherForm.Columns.Count; i++)
								{
									worksheet.Cells[1, i + 1].Value = dataGridViewFromOtherForm.Columns[i].HeaderText;
									worksheet.Cells[1, i + 1].Style.Font.Bold = true;

									for (int j = 0; j < dataGridViewFromOtherForm.Rows.Count; j++)
									{
										worksheet.Cells[j + 2, i + 1].Value = dataGridViewFromOtherForm[i, j].Value;

										// Kiểm tra nền màu của dòng trong DataGridView
										if (dataGridViewFromOtherForm.Rows[j].DefaultCellStyle.BackColor == Color.Red)
										{
											// Đặt màu đỏ cho ô trong tệp Excel
											worksheet.Cells[j + 2, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
											worksheet.Cells[j + 2, i + 1].Style.Fill.BackgroundColor.SetColor(Color.Red);
										}

										// Thêm định dạng viền cho ô
										worksheet.Cells[j + 2, i + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
									}
								}

								package.SaveAs(new FileInfo(filePath));
							}

							MessageBox.Show("Dữ liệu đã được xuất thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

			}
			else
			{
				MessageBox.Show("Vui lòng mở form nhập dữ liệu lịch thi trước.");
			}

		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Phần Mềm Sắp Lịch Thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}

}
