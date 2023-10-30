using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DAL_XepLichThi
{
	public class ScheduleColoringAlgorithm
	{
		public List<ExamSlot> ExamSlots { get; set; } = new List<ExamSlot>();
		public class ExamSlot
		{
			public DateTime ExamDate { get; set; } // Ngày thi
			public string? ExamTime { get; set; }   // Giờ thi
		}
		public List<string> SelectedRooms { get; set; } = new List<string>(); // Danh sách các phòng học đã chọn
		public Dictionary<string, Color> RoomOccupancy { get; set; } = new Dictionary<string, Color>();

		public void ColorExams()
		{
			var colors = new List<Color>
			{
				Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple, Color.Brown
			};

			foreach (var exam in ExamSlots)
			{
				var availableColors = GetAvailableColors(exam, colors);
				RoomOccupancy[exam.ExamDate.ToString("yyyyMMdd") + exam.ExamTime] = availableColors.First();
			}
		}

		private List<Color> GetAvailableColors(ExamSlot exam, List<Color> colors)
		{
			var adjacentColors = GetAdjacentColors(exam);
			return colors.Except(adjacentColors).ToList();
		}

		private List<Color> GetAdjacentColors(ExamSlot exam)
		{
			return SelectedRooms
				.Where(room => RoomOccupancy.ContainsKey(exam.ExamDate.ToString("yyyyMMdd") + exam.ExamTime) && RoomOccupancy[exam.ExamDate.ToString("yyyyMMdd") + exam.ExamTime] != Color.Black)
				.Select(room => RoomOccupancy[exam.ExamDate.ToString("yyyyMMdd") + exam.ExamTime])
				.ToList();
		}
	}
}
