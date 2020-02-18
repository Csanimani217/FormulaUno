using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    /// <summary>
    /// a service réteg feladata az üzleti logika megvalósítása
    /// kapcsolatot teremt a controller és repository réteg között
    /// </summary>
    class TeamService
    {
        F1 f1Repository;

        public TeamService ()
        {
            f1Repository = new F1();
        }
    }
}
