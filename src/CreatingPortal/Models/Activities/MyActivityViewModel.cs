using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingPortal.Models.Activities
{
    public class MyActivityViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPublic { get; set; }
        public KindOfActivity KindOfActivity { get; set; }
    }
}
