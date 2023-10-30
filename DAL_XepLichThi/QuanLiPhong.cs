using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_XepLichThi
{
	public class QuanLiPhong
	{
		public QuanLiPhong(string tenphong) {
			this.tenphong = tenphong;
		}
		private string tenphong;

		public string Tenphong { get => tenphong; set => tenphong = value; }
	}
}
