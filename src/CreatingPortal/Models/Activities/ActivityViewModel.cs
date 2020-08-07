using System;

namespace CreatingPortal.Models.Activities
{
    public class ActivityViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPublic { get; set; }
    }
}
