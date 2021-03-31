using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroCreatorRPG
{
    static public class playerList
    {
        private static List<player> listOfPlayers = new List<player>();

        internal static List<player> ListOfPlayers { get => listOfPlayers; set => listOfPlayers = value; }
    }
}
