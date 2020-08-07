using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Pickers
{
    public class PickerViewModel : ActivityViewModel
    {
        public IEnumerable<PickerTopicViewModel> Topics { get; set; }
    }
}
