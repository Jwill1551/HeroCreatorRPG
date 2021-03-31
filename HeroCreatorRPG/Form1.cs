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
    public partial class Form1 : Form
    {
        string picturePortrait = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Attributes_Enter(object sender, EventArgs e)
        {

        }

        private void createCharacterBtn_Click(object sender, EventArgs e)
        {
            string name = playerNameTextBox.Text;
            string charStatus = "Your character contains the following status information: ";

            string className = classNameTextBox.Text;

            // List of skills
            bool[] skills = { false, false, false, false, false, false, false, false, false, false };

            skills[0] = archerySkillBox.Checked;
            skills[1] = barteringSkillBox.Checked;
            skills[2] = lockpickingSkillBox.Checked;
            skills[3] = sharpshooterSkillBox.Checked;
            skills[4] = craftsmanshipSkillBox.Checked;
            skills[5] = combatSkillBox.Checked;
            skills[6] = magicSkillBox.Checked;
            skills[7] = enchantingSkillBox.Checked;
            skills[8] = huntingSkillBox.Checked;
            skills[9] = alchemistSkillBox.Checked;

            charStatus += "Skills: ";

            if (skills[0]) charStatus += "Archery, ";
            if (skills[1]) charStatus += "Bartering, ";
            if (skills[2]) charStatus += "Lockpicking, ";
            if (skills[3]) charStatus += "Sharpshooter, ";
            if (skills[4]) charStatus += "Craftsmanship, ";
            if (skills[5]) charStatus += "Combat Expert, ";
            if (skills[6]) charStatus += "Magic, ";
            if (skills[7]) charStatus += "Enchanting, ";
            if (skills[8]) charStatus += "Hunting, ";
            if (skills[9]) charStatus += "Alchemist. ";

            //List of Location 
            List<String> locations = new List<String>();
            foreach (String s in locationListBox.SelectedItems) locations.Add(s);


            // Race
            string playerRace = "Human";
            if (humanRadioBtn.Checked) playerRace = "Human";
            if (elfRadioBtn.Checked) playerRace = "Elf";
            if (orcRadioBtn.Checked) playerRace = "Orc";
            if (beastmanRadioBtn.Checked) playerRace = "Beastman";
            if (darkElfRadioBtn.Checked) playerRace = "Dark Elf";
            if (dwarfRadioBtn.Checked) playerRace = "Dawrf";
            if (spriteRadioBtn.Checked) playerRace = "Sprite";

            // Gender
            string playerGender = "Male";
            if (maleRadioBtn.Checked) playerGender = "Male";
            if (femaleRadioBtn.Checked) playerGender = "Female";

            // Time Adventuring
            int timeAdventuring = int.Parse(adventurerCounter.Value.ToString());

            // Attributes 
            List<int> listOfAttributes = new List<int>();
            int strength = int.Parse(strengthValueLabel.Text);
            int stamina = int.Parse(staminaValueLabel.Text);
            int intelligence = int.Parse(intelligenceValueLabel.Text);
            int faith = int.Parse(faithValueLabel.Text);
            int defense = int.Parse(defenseValueLabel.Text);
            int magicDefense = int.Parse(magicDefenseValueLabel.Text);
            listOfAttributes.Add(strength);
            listOfAttributes.Add(stamina);
            listOfAttributes.Add(intelligence);
            listOfAttributes.Add(faith);
            listOfAttributes.Add(defense);
            listOfAttributes.Add(magicDefense);

            // Dates 
            List<String> listOfDates = new List<String>();
            DateTime dateOfBirth = doaDatePicker.Value;
            DateTime joinedAGuild = joinedAGuildDatePicker.Value;
            DateTime adventruing = adventuringDatePicker.Value;
            listOfDates.Add(dateOfBirth.ToString());
            listOfDates.Add(joinedAGuild.ToString());
            listOfDates.Add(adventruing.ToString());

            // Eye Color
            string eyeColor = colorBox.BackColor.ToString();

            // Morality
            int moralityScale = moralityScrollBar.Value;

            // Personality 
            string personality = "Calm";
            if (calmRadioBtn.Checked) personality = "Calm";
            if (confidentRadioBtn.Checked) personality = "Confident";
            if (boldRadioBtn.Checked) personality = "Bold";
            if (aggitatedRadioBtn.Checked) personality = "Aggitated";
            if (courageousRadioBtn.Checked) personality = "Courageous";
            if (cautiousRadioBtn.Checked) personality = "Cautious";

            // Picture Portrait
            string picturePortrait = " ";

            player newPlayer = new player(name, className, skills, listOfDates, locations, playerRace, playerGender, timeAdventuring, eyeColor, moralityScale, listOfAttributes, personality, picturePortrait);
            playerList.ListOfPlayers.Add(newPlayer);

            MessageBox.Show("The following Player patarmeters have been created: "
                + "\n Name: " + name
                + "\n Class Name: " + className
                + "\n Skills: " + skills
                + "\n Dates: " + listOfDates
                + "\n Location(s): " + locations.ToString()
                + "\n Race: " + playerRace
                + "\n Gender: " + playerGender
                + "\n Time Adventuring: " + timeAdventuring
                + "\n Eye Color: " + eyeColor
                + "\n Morality: " + moralityScale
                + "\n Attributes: [Strength: " + strengthHScrollBar.Value.ToString() + "] [Stamina: " + staminaHScrollBar.Value.ToString() + "] [Intelligence: " + intelligenceHScrollBar.Value.ToString() + "] [Faith: " + faithHScrollBar.Value.ToString() + "] [Defense: " + defenseHScrollBar.Value.ToString() + "] [Magic Defense: " + magicDefenseHScrollBar.Value.ToString()
                + "] \n Personality: " + personality
                + "\n Picture: " + picturePortrait);

            MessageBox.Show("You have made " + playerList.ListOfPlayers.Count() + " Characters");

            playerPreview PlayerPreview = new playerPreview();
            PlayerPreview.Show();
        }

        private void strengthHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            strengthValueLabel.Text = strengthHScrollBar.Value.ToString();
        }

        private void staminaHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            staminaValueLabel.Text = staminaHScrollBar.Value.ToString();
        }

        private void intelligenceHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            intelligenceValueLabel.Text = intelligenceHScrollBar.Value.ToString();
        }

        private void faithHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            faithValueLabel.Text = faithHScrollBar.Value.ToString();
        }

        private void defenseHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            defenseValueLabel.Text = defenseHScrollBar.Value.ToString();
        }

        private void magicDefenseHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            magicDefenseValueLabel.Text = magicDefenseHScrollBar.Value.ToString();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorPicker.Color;
            }
        }

        private void moralityScrollBar_Scroll(object sender, EventArgs e)
        {
            moralityLabelValue.Text = moralityScrollBar.Value.ToString();
        }

        private void portraitBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog portraitPicker = new OpenFileDialog();
            if(portraitPicker.ShowDialog() == DialogResult.OK)
            {
                portraitBox.Image = new Bitmap(portraitPicker.FileName);

                picturePortrait = portraitPicker.FileName;
            }
        }
    }
}
