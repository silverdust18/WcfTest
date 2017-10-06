using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyGameService
    {
        [OperationContract]
        void AddGame(Game g);


        [OperationContract]
        List<Game> GetAllGames();


        [OperationContract]
        Game GetGameByID(int id);

    }

    [DataContract]
    public class Game
    {
        [DataMember]
        public int ID { set; get; }
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string Publisher { set; get; }
        public Game() { }
    }

}
