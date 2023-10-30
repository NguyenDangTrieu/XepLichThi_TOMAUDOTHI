namespace GUI_XepLichThi
{
	partial class TrangChu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			trangChủToolStripMenuItem = new ToolStripMenuItem();
			nhậpFileToolStripMenuItem = new ToolStripMenuItem();
			thoátToolStripMenuItem = new ToolStripMenuItem();
			chứcNăngToolStripMenuItem = new ToolStripMenuItem();
			sắpXếpLịchToolStripMenuItem = new ToolStripMenuItem();
			xuấtFileToolStripMenuItem = new ToolStripMenuItem();
			càiĐặtToolStripMenuItem = new ToolStripMenuItem();
			quảnLíGiờThiToolStripMenuItem = new ToolStripMenuItem();
			panel_body = new Panel();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			panel_top = new Panel();
			menuStrip1.SuspendLayout();
			panel_body.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, chứcNăngToolStripMenuItem, càiĐặtToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1102, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, nhậpFileToolStripMenuItem, thoátToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// trangChủToolStripMenuItem
			// 
			trangChủToolStripMenuItem.Image = Properties.Resources.home_button;
			trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
			trangChủToolStripMenuItem.Size = new Size(224, 26);
			trangChủToolStripMenuItem.Text = "Trang Chủ";
			trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
			// 
			// nhậpFileToolStripMenuItem
			// 
			nhậpFileToolStripMenuItem.Image = Properties.Resources.google_docs__1_;
			nhậpFileToolStripMenuItem.Name = "nhậpFileToolStripMenuItem";
			nhậpFileToolStripMenuItem.Size = new Size(224, 26);
			nhậpFileToolStripMenuItem.Text = "Nhập File";
			nhậpFileToolStripMenuItem.Click += nhậpFileToolStripMenuItem_Click;
			// 
			// thoátToolStripMenuItem
			// 
			thoátToolStripMenuItem.Image = Properties.Resources.log_out;
			thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			thoátToolStripMenuItem.Size = new Size(224, 26);
			thoátToolStripMenuItem.Text = "Thoát";
			thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
			// 
			// chứcNăngToolStripMenuItem
			// 
			chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sắpXếpLịchToolStripMenuItem, xuấtFileToolStripMenuItem });
			chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			chứcNăngToolStripMenuItem.Size = new Size(96, 24);
			chứcNăngToolStripMenuItem.Text = "Chức Năng";
			// 
			// sắpXếpLịchToolStripMenuItem
			// 
			sắpXếpLịchToolStripMenuItem.Image = Properties.Resources.fuzzy;
			sắpXếpLịchToolStripMenuItem.Name = "sắpXếpLịchToolStripMenuItem";
			sắpXếpLịchToolStripMenuItem.Size = new Size(224, 26);
			sắpXếpLịchToolStripMenuItem.Text = "Sắp Xếp Lịch";
			sắpXếpLịchToolStripMenuItem.Click += sắpXếpLịchToolStripMenuItem_Click;
			// 
			// xuấtFileToolStripMenuItem
			// 
			xuấtFileToolStripMenuItem.Image = Properties.Resources.add;
			xuấtFileToolStripMenuItem.Name = "xuấtFileToolStripMenuItem";
			xuấtFileToolStripMenuItem.Size = new Size(224, 26);
			xuấtFileToolStripMenuItem.Text = "Xuất File";
			xuấtFileToolStripMenuItem.Click += xuấtFileToolStripMenuItem_Click;
			// 
			// càiĐặtToolStripMenuItem
			// 
			càiĐặtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLíGiờThiToolStripMenuItem });
			càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
			càiĐặtToolStripMenuItem.Size = new Size(72, 24);
			càiĐặtToolStripMenuItem.Text = "Cài Đặt";
			// 
			// quảnLíGiờThiToolStripMenuItem
			// 
			quảnLíGiờThiToolStripMenuItem.Image = Properties.Resources.clock;
			quảnLíGiờThiToolStripMenuItem.Name = "quảnLíGiờThiToolStripMenuItem";
			quảnLíGiờThiToolStripMenuItem.Size = new Size(224, 26);
			quảnLíGiờThiToolStripMenuItem.Text = "Quản Lí Giờ Thi";
			quảnLíGiờThiToolStripMenuItem.Click += quảnLíGiờThiToolStripMenuItem_Click;
			// 
			// panel_body
			// 
			panel_body.BackColor = Color.FromArgb(192, 255, 255);
			panel_body.Controls.Add(label5);
			panel_body.Controls.Add(label4);
			panel_body.Controls.Add(label3);
			panel_body.Controls.Add(label2);
			panel_body.Controls.Add(label1);
			panel_body.Dock = DockStyle.Fill;
			panel_body.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			panel_body.Location = new Point(0, 126);
			panel_body.Name = "panel_body";
			panel_body.Size = new Size(1102, 442);
			panel_body.TabIndex = 2;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(49, 358);
			label5.Name = "label5";
			label5.Size = new Size(428, 31);
			label5.TabIndex = 4;
			label5.Text = "2001215738 - Nguyễn Mai Quỳnh Giao";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(49, 317);
			label4.Name = "label4";
			label4.Size = new Size(412, 31);
			label4.TabIndex = 3;
			label4.Text = "2001216069 - Phạm Thị Kim Phượng ";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(49, 274);
			label3.Name = "label3";
			label3.Size = new Size(371, 31);
			label3.TabIndex = 2;
			label3.Text = "2001216243 - Nguyễn Đăng Triều";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(38, 223);
			label2.Name = "label2";
			label2.Size = new Size(292, 38);
			label2.TabIndex = 1;
			label2.Text = "Sinh Viên Thực Hiện:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(205, 100);
			label1.Name = "label1";
			label1.Size = new Size(686, 50);
			label1.TabIndex = 0;
			label1.Text = "DEMO PHẦN MỀM SẮP XẾP LỊCH HỌC";
			// 
			// panel_top
			// 
			panel_top.BackColor = Color.White;
			panel_top.BackgroundImage = (Image)resources.GetObject("panel_top.BackgroundImage");
			panel_top.BackgroundImageLayout = ImageLayout.Center;
			panel_top.Dock = DockStyle.Top;
			panel_top.Location = new Point(0, 28);
			panel_top.Name = "panel_top";
			panel_top.Size = new Size(1102, 98);
			panel_top.TabIndex = 1;
			// 
			// TrangChu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1102, 568);
			Controls.Add(panel_body);
			Controls.Add(panel_top);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "TrangChu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Phần Mềm Sắp Xếp Lịch Thi";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel_body.ResumeLayout(false);
			panel_body.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem trangChủToolStripMenuItem;
		private ToolStripMenuItem nhậpFileToolStripMenuItem;
		private ToolStripMenuItem thoátToolStripMenuItem;
		private ToolStripMenuItem chứcNăngToolStripMenuItem;
		private ToolStripMenuItem sắpXếpLịchToolStripMenuItem;
		private ToolStripMenuItem xuấtFileToolStripMenuItem;
		private ToolStripMenuItem càiĐặtToolStripMenuItem;
		private ToolStripMenuItem quảnLíGiờThiToolStripMenuItem;
		private Panel panel_body;
		private Label label1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Panel panel_top;
	}
}