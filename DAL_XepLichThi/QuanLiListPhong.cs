using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_XepLichThi
{
	public class QuanLiListPhong
	{
		List<QuanLiPhong> quanLiPhongs = new List<QuanLiPhong>();

		public QuanLiListPhong()
		{
		}

		public List<QuanLiPhong> TaoDanhSachPhong()
		{
			// Tạo danh sách các đối tượng QuanLiPhong và thêm vào danh sách
			quanLiPhongs.Add(new QuanLiPhong("A202"));
			quanLiPhongs.Add(new QuanLiPhong ("A201"));
			quanLiPhongs.Add(new QuanLiPhong ("A203"));
			quanLiPhongs.Add(new QuanLiPhong("B202"));
			quanLiPhongs.Add(new QuanLiPhong("B201"));
			quanLiPhongs.Add(new QuanLiPhong("B203"));
			return quanLiPhongs;
		}
	}
}
