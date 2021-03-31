using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroCreatorRPG
{
    public partial class playerPreview : Form
    {
        BindingSource bs = new BindingSource();
        public playerPreview()
        {
            InitializeComponent();
            
            bs.DataSource = playerList.ListOfPlayers;
            playerListBox.DataSource = bs;
            playerListBox.DisplayMember = "playerName";
        }

        private void aToZBtn_Click(object sender, EventArgs e)
        {
            playerList.ListOfPlayers.Sort();
            bs.ResetBindings(false);
        }

        private void zToABtn_Click(object sender, EventArgs e)
        {
            playerList.ListOfPlayers.Sort();
            playerList.ListOfPlayers.Reverse();
            bs.ResetBindings(false);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            playerList.ListOfPlayers.Remove((player)playerListBox.SelectedItem);
            bs.ResetBindings(false);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                playerStatus.Text = playerListBox.SelectedItem.ToString();
            }
            catch { }
        }
    }
}
