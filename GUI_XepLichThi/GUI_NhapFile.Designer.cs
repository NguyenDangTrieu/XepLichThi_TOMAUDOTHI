namespace GUI_XepLichThi
{
	partial class GUI_NhapFile
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
			dataGridView_NhapDuLieu = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			NgayThi = new DataGridViewTextBoxColumn();
			GioThi = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView_NhapDuLieu).BeginInit();
			SuspendLayout();
			// 
			// dataGridView_NhapDuLieu
			// 
			dataGridView_NhapDuLieu.AllowUserToAddRows = false;
			dataGridView_NhapDuLieu.AllowUserToDeleteRows = false;
			dataGridView_NhapDuLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_NhapDuLieu.BackgroundColor = Color.White;
			dataGridView_NhapDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_NhapDuLieu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, NgayThi, GioThi, Column10, Column11 });
			dataGridView_NhapDuLieu.Dock = DockStyle.Fill;
			dataGridView_NhapDuLieu.Location = new Point(0, 0);
			dataGridView_NhapDuLieu.Name = "dataGridView_NhapDuLieu";
			dataGridView_NhapDuLieu.RowHeadersWidth = 51;
			dataGridView_NhapDuLieu.RowTemplate.Height = 29;
			dataGridView_NhapDuLieu.Size = new Size(1365, 462);
			dataGridView_NhapDuLieu.TabIndex = 0;
			dataGridView_NhapDuLieu.CellContentClick += dataGridView_NhapDuLieu_CellContentClick;
			dataGridView_NhapDuLieu.CellMouseUp += dataGridView_NhapDuLieu_CellMouseUp;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			Column1.HeaderText = "STT";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.Width = 62;
			// 
			// Column2
			// 
			Column2.HeaderText = "MÃ HP";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			// 
			// Column3
			// 
			Column3.HeaderText = "TÊN HỌC PHẦN\r\n";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			// 
			// Column4
			// 
			Column4.HeaderText = "SỐ TC\r\n";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			// 
			// Column5
			// 
			Column5.HeaderText = "SỐ SV\r\n";
			Column5.MinimumWidth = 6;
			Column5.Name = "Column5";
			// 
			// Column6
			// 
			Column6.HeaderText = "HT THI\r\n";
			Column6.MinimumWidth = 6;
			Column6.Name = "Column6";
			// 
			// Column7
			// 
			Column7.HeaderText = "THỜI LƯỢNG";
			Column7.MinimumWidth = 6;
			Column7.Name = "Column7";
			// 
			// NgayThi
			// 
			NgayThi.HeaderText = "NGÀY";
			NgayThi.MinimumWidth = 6;
			NgayThi.Name = "NgayThi";
			// 
			// GioThi
			// 
			GioThi.HeaderText = "GIỜ THI";
			GioThi.MinimumWidth = 6;
			GioThi.Name = "GioThi";
			// 
			// Column10
			// 
			Column10.HeaderText = "PHÒNG";
			Column10.MinimumWidth = 6;
			Column10.Name = "Column10";
			// 
			// Column11
			// 
			Column11.HeaderText = "LỚP";
			Column11.MinimumWidth = 6;
			Column11.Name = "Column11";
			// 
			// GUI_NhapFile
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1365, 462);
			Controls.Add(dataGridView_NhapDuLieu);
			Name = "GUI_NhapFile";
			Text = "GUI_NhapFile";
			((System.ComponentModel.ISupportInitialize)dataGridView_NhapDuLieu).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView_NhapDuLieu;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn NgayThi;
		private DataGridViewTextBoxColumn GioThi;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
	}
}