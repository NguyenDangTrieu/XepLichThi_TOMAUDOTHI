namespace GUI_XepLichThi
{
	partial class GUI_ChonPhongThi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChonPhongThi));
			panelbody = new Panel();
			btnChapnhan = new Button();
			btnhuy = new Button();
			SuspendLayout();
			// 
			// panelbody
			// 
			panelbody.BackColor = Color.White;
			panelbody.Location = new Point(2, -3);
			panelbody.Name = "panelbody";
			panelbody.Size = new Size(369, 390);
			panelbody.TabIndex = 0;
			// 
			// btnChapnhan
			// 
			btnChapnhan.BackColor = Color.FromArgb(192, 255, 255);
			btnChapnhan.Location = new Point(30, 409);
			btnChapnhan.Name = "btnChapnhan";
			btnChapnhan.Size = new Size(94, 29);
			btnChapnhan.TabIndex = 1;
			btnChapnhan.Text = "Chấp Nhận";
			btnChapnhan.UseVisualStyleBackColor = false;
			btnChapnhan.Click += btnChapnhan_Click_1;
			// 
			// btnhuy
			// 
			btnhuy.BackColor = Color.FromArgb(192, 255, 255);
			btnhuy.Location = new Point(208, 409);
			btnhuy.Name = "btnhuy";
			btnhuy.Size = new Size(94, 29);
			btnhuy.TabIndex = 2;
			btnhuy.Text = "Hủy";
			btnhuy.UseVisualStyleBackColor = false;
			btnhuy.Click += btnhuy_Click;
			// 
			// GUI_ChonPhongThi
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 255);
			ClientSize = new Size(371, 450);
			Controls.Add(btnhuy);
			Controls.Add(btnChapnhan);
			Controls.Add(panelbody);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "GUI_ChonPhongThi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CHỌN PHÒNG THI";
			ResumeLayout(false);
		}

		#endregion

		private Panel panelbody;
		private Button btnChapnhan;
		private Button btnhuy;
	}
}