using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.Pickers
{
    public class PickerCreationViewModel : ActivityCreationViewModel
    {
        public IEnumerable<PickerTopicViewModel> Topics { get; set; }
    }
}
