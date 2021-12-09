using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.LorRankedV1;

namespace LORLeaderboardViewer
{ 
    public partial class MainForm : Form
    {
        internal LeaderboardViewer ViewModel;
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new LeaderboardViewer();
            PlayerListBox.DataSource = ViewModelBindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ViewModel.RiotAPI = RiotApi.NewInstance(APIKeyTextbox.Text);
                Region region = MingweiSamuel.Camille.Enums.Region.Get(RegionBox.SelectedItem.ToString());
                var Leaderboard = ViewModel.RiotAPI.LorRankedV1.GetLeaderboards(region);
                ViewModel.Players = new BindingList<Player>(Leaderboard.Players);
                MessageBox.Show("Successful");
            }
            catch
            {
                MessageBox.Show("Invalid Region or API Key.", "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
