using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trelloGitter
{
    class trelloGitter
    {
        static void Main()
        {
            GitLog git = new GitLog();
            TrelloBoard trello = new TrelloBoard();
            Reconciler reconciler = new Reconciler();
            return;
        }
    }
}
