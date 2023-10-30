namespace GUI_XepLichThi
{
	partial class QL_GioThi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_GioThi));
			panel1 = new Panel();
			dataGridViewGioThi = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			dateTimePickerngaybatdau = new DateTimePicker();
			dateTimePickerNgayketthuc = new DateTimePicker();
			btnluu = new Button();
			btnthoat = new Button();
			btnlayngay = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewGioThi).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(dataGridViewGioThi);
			panel1.Location = new Point(-1, 49);
			panel1.Name = "panel1";
			panel1.Size = new Size(780, 210);
			panel1.TabIndex = 0;
			panel1.UseWaitCursor = true;
			// 
			// dataGridViewGioThi
			// 
			dataGridViewGioThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewGioThi.BackgroundColor = Color.FromArgb(192, 255, 255);
			dataGridViewGioThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewGioThi.GridColor = Color.FromArgb(192, 192, 255);
			dataGridViewGioThi.Location = new Point(0, 0);
			dataGridViewGioThi.Name = "dataGridViewGioThi";
			dataGridViewGioThi.RowHeadersWidth = 51;
			dataGridViewGioThi.RowTemplate.Height = 29;
			dataGridViewGioThi.Size = new Size(780, 210);
			dataGridViewGioThi.TabIndex = 0;
			dataGridViewGioThi.UseWaitCursor = true;
			dataGridViewGioThi.CellContentClick += dataGridViewGioThi_CellContentClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(104, 20);
			label1.TabIndex = 1;
			label1.Text = "Ngày Bắt Đầu:";
			label1.UseWaitCursor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(323, 9);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 2;
			label2.Text = "Ngày Kết Thúc:";
			label2.UseWaitCursor = true;
			// 
			// dateTimePickerngaybatdau
			// 
			dateTimePickerngaybatdau.Format = DateTimePickerFormat.Custom;
			dateTimePickerngaybatdau.Location = new Point(125, 4);
			dateTimePickerngaybatdau.Name = "dateTimePickerngaybatdau";
			dateTimePickerngaybatdau.Size = new Size(192, 27);
			dateTimePickerngaybatdau.TabIndex = 3;
			dateTimePickerngaybatdau.UseWaitCursor = true;
			// 
			// dateTimePickerNgayketthuc
			// 
			dateTimePickerNgayketthuc.Format = DateTimePickerFormat.Custom;
			dateTimePickerNgayketthuc.Location = new Point(437, 6);
			dateTimePickerNgayketthuc.Name = "dateTimePickerNgayketthuc";
			dateTimePickerNgayketthuc.Size = new Size(191, 27);
			dateTimePickerNgayketthuc.TabIndex = 4;
			dateTimePickerNgayketthuc.UseWaitCursor = true;
			// 
			// btnluu
			// 
			btnluu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnluu.Location = new Point(563, 273);
			btnluu.Name = "btnluu";
			btnluu.Size = new Size(94, 29);
			btnluu.TabIndex = 5;
			btnluu.Text = "Lưu";
			btnluu.UseVisualStyleBackColor = true;
			btnluu.UseWaitCursor = true;
			btnluu.Click += btnluu_Click;
			// 
			// btnthoat
			// 
			btnthoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnthoat.Location = new Point(674, 273);
			btnthoat.Name = "btnthoat";
			btnthoat.Size = new Size(94, 29);
			btnthoat.TabIndex = 6;
			btnthoat.Text = "Thoát";
			btnthoat.UseVisualStyleBackColor = true;
			btnthoat.UseWaitCursor = true;
			btnthoat.Click += btnthoat_Click;
			// 
			// btnlayngay
			// 
			btnlayngay.BackColor = Color.FromArgb(192, 192, 255);
			btnlayngay.Location = new Point(664, 4);
			btnlayngay.Name = "btnlayngay";
			btnlayngay.Size = new Size(94, 29);
			btnlayngay.TabIndex = 7;
			btnlayngay.Text = "Lấy Ngày";
			btnlayngay.UseVisualStyleBackColor = false;
			btnlayngay.UseWaitCursor = true;
			btnlayngay.Click += btnlayngay_Click;
			// 
			// QL_GioThi
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 255);
			ClientSize = new Size(780, 306);
			Controls.Add(btnlayngay);
			Controls.Add(btnthoat);
			Controls.Add(btnluu);
			Controls.Add(dateTimePickerNgayketthuc);
			Controls.Add(dateTimePickerngaybatdau);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "QL_GioThi";
			StartPosition = FormStartPosition.CenterScreen;
			Tag = "Quản Lí Giờ Thi";
			Text = "Quản Lí Giờ Thi";
			TopMost = true;
			UseWaitCursor = true;
			Load += QL_GioThi_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewGioThi).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private DataGridView dataGridViewGioThi;
		private Label label1;
		private Label label2;
		private DateTimePicker dateTimePickerngaybatdau;
		private DateTimePicker dateTimePickerNgayketthuc;
		private Button btnluu;
		private Button btnthoat;
		private Button btnlayngay;
	}
}