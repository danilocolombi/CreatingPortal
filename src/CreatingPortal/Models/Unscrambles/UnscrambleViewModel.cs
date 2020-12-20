using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Unscrambles
{
    public class UnscrambleViewModel : ActivityViewModel
    {
        public IEnumerable<ExerciseViewModel> Exercises { get; set; }
    }
}
