using CreatingPortal.Models.Activities;
using System.Collections.Generic;

namespace CreatingPortal.Models.TicTacToes
{
    public class TicTacToeViewModel : ActivityViewModel
    {
        public IEnumerable<TicTacToeSquareViewModel> Squares { get; set; }
    }
}
