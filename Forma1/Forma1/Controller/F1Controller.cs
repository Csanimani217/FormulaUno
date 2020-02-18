using Forma1.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    /// <summary>
    /// Controlller réteg kapcsolatot teremt a GUi és a service réteg között
    /// feladata a bemenő adatok vizsgálata
    /// feladata a megjelenítendő adatok átalakítása a GUI számára
    /// </summary>
    class F1Controller
    {
        TeamService teamService;

        public F1Controller()
        {
            teamService = new TeamService();
        }
    }
}
