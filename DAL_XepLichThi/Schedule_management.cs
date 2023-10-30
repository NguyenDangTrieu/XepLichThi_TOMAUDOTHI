using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_XepLichThi
{
	public class Schedule_management
	{
		public string StartTime { get; set; }

		public Schedule_management(string startTime)
		{
			StartTime = startTime;
		}
	}
}
