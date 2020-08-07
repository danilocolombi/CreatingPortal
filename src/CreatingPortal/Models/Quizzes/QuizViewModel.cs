using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Quizzes
{
    public class QuizViewModel : ActivityViewModel
    {
        public ICollection<QuizQuestionViewModel> Questions { get; set; }
    }
}
