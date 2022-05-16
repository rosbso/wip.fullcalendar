namespace wip.fullcalendar.Models
{
    public class HorarioViewModel
    {
        public string Id { get; set; }
        public bool AllDay { get; set; }
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartRecur { get; set; }
        public string EndRecur { get; set; }
        public int[] DaysOfWeek { get; set; }

    }
}
