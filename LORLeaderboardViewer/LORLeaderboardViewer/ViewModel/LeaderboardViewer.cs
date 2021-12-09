using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille.LorRankedV1;
using MingweiSamuel.Camille;
using System.ComponentModel;

namespace LORLeaderboardViewer
{
    public class LeaderboardViewer : INotifyPropertyChanged
    {
        public RiotApi RiotAPI;

        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Player> Players { get; set; }

        public string Name { get; set; }

        public int Rank { get; set; }

        public int LeaguePoints { get; set; }

        public LeaderboardViewer(RiotApi riotApi = null)
        {
            RiotAPI = riotApi;
        }

    }
}
