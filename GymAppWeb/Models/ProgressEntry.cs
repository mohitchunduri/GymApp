namespace GymAppWeb.Models
{
    public class ProgressEntry
    {
        public DateTime Date { get; set; }
        public string Exercise { get; set; } = string.Empty;
        public int Reps { get; set; }
    }
}
