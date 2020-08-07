using System.Collections.Generic;

namespace CreatingPortal.Models.Quizzes
{
    public class QuizQuestionCreationViewModel
    {
        public string Description { get; set; }
        public IEnumerable<AlternativeViewModel> Alternatives { get; set; }
    }
}
