using LOG660.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG660.FACADE
{
    public class WebFlixFacade
    {
        private static MovieEntity _entityWebFlixMgr;
        
        //Singleton de  l'objet de la BD
        public static MovieEntity getInstance
        {
            get
            {
                if (_entityWebFlixMgr == null)
                   _entityWebFlixMgr = new MovieEntity();

                return _entityWebFlixMgr;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usercode"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public USAGER connectUserWithCredentials(string usercode, string userPassword)
        {
            if (!String.IsNullOrEmpty(usercode) && !String.IsNullOrEmpty(userPassword))        
                return _entityWebFlixMgr.USAGERs.FirstOrDefault(u => u.COURRIEL.ToLower().Equals(usercode.ToLower()) && u.MOTPASSE.Equals(userPassword));
         
            return null;
        }



    }
}
