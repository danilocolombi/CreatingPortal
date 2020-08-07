using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Unscrambles
{
    public class UnscrambleCreationViewModel : ActivityCreationViewModel
    {
        public IEnumerable<ExerciseViewModel> Exercises { get; set; }
    }
}
