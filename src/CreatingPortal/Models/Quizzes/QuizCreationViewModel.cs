using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Quizzes
{
    public class QuizCreationViewModel : ActivityCreationViewModel
    {
        public IEnumerable<QuizQuestionCreationViewModel> Questions { get; set; }
    }
}
