using System.Collections.Generic;

namespace CreatingPortal.Models.Core
{
    public class ResultResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; } = new List<string>();
    }
}
