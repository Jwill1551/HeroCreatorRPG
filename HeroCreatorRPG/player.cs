using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroCreatorRPG
{
    public class player : IComparable
    {
        public string playerName;
        private string className;
        private bool[] skills;
        private List<String> dates;
        private List<String> locations;
        private string race;
        private string gender;
        private int timesAdventuring;
        private string eyeColor;
        private int morality;
        private List<int> attributes;
        private string personality;
        private string portrait;

        public player(string pn, string cn, bool[] arr1, List<String> arr2, List<String> ls, string r, string g, int ta, string ea, int m, List<int> att, string p, string po)
        {
            this.playerName = pn;
            this.className = cn;
            this.skills = arr1;
            this.dates = arr2;
            this.locations = ls;
            this.race = r;
            this.gender = g;
            this.timesAdventuring = ta;
            this.eyeColor = ea;
            this.morality = m;
            this.attributes = att;
            this.personality = p;
            this.portrait = po;
        }

        public player()
        {

        }

        public string PlayerName { get => playerName; set => playerName = value; }
        public string ClassName { get => className; set => className = value; }
        public bool[] Skills { get => skills; set => skills = value; }
        public List<String> Dates { get => dates; set => dates = value; }
        public List<String> Locations { get => locations; set => locations = value; }
        public string Race { get => race; set => race = value; }
        public string Gender { get => gender; set => gender = value; }
        public int TimesAdventuring { get => timesAdventuring; set => timesAdventuring = value; }
        public string EyeColor { get => eyeColor; set => eyeColor = value; }
        public int Morality { get => morality; set => morality = value; }
        public List<int> Attributes { get => attributes; set => attributes = value; }
        public string Personality { get => personality; set => personality = value; }

        public int CompareTo(object obj)
        {
            player other = (player)obj;
            return playerName.CompareTo(other.playerName);
        }
    }
}
