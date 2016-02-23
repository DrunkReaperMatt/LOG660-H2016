using LOG660.FACADE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG660.HELPERS
{
    public class Helpers
    {
        public static bool isClient(decimal idUser)
        {
            return WebFlixFacade.getInstance.getEntity.CLIENTs.Any(c => c.IDUSAGER == idUser);
        }

        public static bool isMovieCount(decimal idMovie)
        {
            return WebFlixFacade.getInstance.getEntity.EXEMPLAIREs.Any(m => m.IDEXEMPLAIRE == idMovie);
        }
    }
}
