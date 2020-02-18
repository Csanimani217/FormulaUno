using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    class TeamService
    {
        F1 f1Repository;

        public TeamService (string teamName)
        {
            f1Repository = new F1();
        }
    }
}
