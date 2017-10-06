using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IMyGameService
    {
        static List<Game> _games = new List<Game>();
        static object locker = new object();


        #region IMyGameService Members 


        public void AddGame(Game g)
        {
            g.ID = GetNextID();
            lock (locker)
            {
                _games.Add(g);
            }
        }


        public List<Game> GetAllGames()
        {
            return _games;
        }


        public Game GetGameByID(int id)
        {
            lock (locker)
            {
                foreach (Game g in _games)
                {
                    if (g.ID == id)
                        return g;
                }
            }
            return null;
        }


        #endregion


        private int GetNextID()
        {
            int maxID = 0;
            lock (locker)
            {
                foreach (Game g in _games)
                {
                    if (g.ID > maxID)
                        maxID = g.ID;
                }
            }
            return maxID + 1;
        }

    }
}
