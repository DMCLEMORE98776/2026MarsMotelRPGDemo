//Here we can add our libraries we will use
// for basic C#
//For lists and collections
// For our basic graphics
// FOr our desktop windows forms we can use
// This is out namespace for this project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026MarsMotelRPGDEMO
{
    public partial class HelloForm1 : Form
    {
        // Inside our class we want to create the properties aka variables that we will use to store our data for our game, such as player stats, inventory, and locations.
        //  int of health
        int playerHealth = 100;
        // int of player's money credits
        int spaceCredits = 50;
        // This is our form constructor, it is what runs when we start the program and opens the form, we can use this to initialize our game and set up our starting conditions.
        public HelloForm1()
        {
            InitializeComponent();
        }

        // This runs auto when our form first loads
        //This of this as like our setup for the values on our screen.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Call the function we made to update health and credits of our user
            UpdateStats();

            // Now let's set up our combo box with the locations we want to be able to explore, this is adding items to the combo box control on our form.
            CMBLocations.Items.Add("Space Station");

            // Let's add another location our user can go to
            CMBLocations.Items.Add("Mars Outpost");

            // Now let's make our combo box select a default location so it is not empty
            CMBLocations.SelectedIndex = 0;

            // Now let's let our user know whats going on in the SIM
            lblStory.Text = "Welcome to the 2026 Mars Motel RPG! You are a space traveler who has just arrived at a space station on Mars. Your goal is to explore the station and the surrounding area, gather resources, and survive in this harsh environment. Good luck!";
        }

        // Create a method that will update the stats
        private void UpdateStats()
        {        {
}

            // This updates stuff on our gui for us
            // This is taking our label control called lblStats and setting it's text property.
            LBLStats.Text = "Health: " + playerHealth.ToString() + " | Credits: " + spaceCredits.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lets use a random number generator to sim a dice roll in the RPG
            Random chance = new Random();

            // Let's generate a number between 1 and 10
            int eventRoll = chance.Next(1, 11);

            //now let check if our random number
            if (eventRoll > 5)
            {
                // Let's make something positive happen in our environment
                lblStory.Text = "While exploring the area, you found an abandon ship with minirals worth 20 credits!";

                    // Let's modify the amount in the user's account
                    spaceCredits = spaceCredits + 20;
            } else if (eventRoll <= 5)
            {
                // Let something negative happen to the user
                lblStory.Text = "A rogue security bot fired upon you! You lost 15 health!";
                
                // This will cost some health
                playerHealth = playerHealth - 15;
            }

            // Refresh the display for our user
            UpdateStats();

            // Has our player health dropped too low?
            if(playerHealth <=0)
            {
                // If the player health is 0 or less, they have died and we can end the game
                lblStory.Text = "You have died! Game Over!";
                // We can also disable the explore button so they can't keep playing after they die
                BTNExplore.Enabled = false;

                // close the app
                Application.Exit();

            }
        }

        // This handles the change of item in our combo box when our user changed to a new value.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Let's check and see what value is now selcted
            if(CMBLocations.SelectedItem.ToString() == "Space Station")
            {
                // If they select the space station we can update the story label to reflect that
                lblStory.Text = "You are now at the space station. You see a shop where you can buy supplies and a bar where you can talk to other travelers.";
                // Let's change the background image to reflect the new location, we can do this by setting the background image property of our form to a new image, we will need to add the image to our project resources first.
                this.BackgroundImage = Properties.Resources.MarsSpaceStationBG_1;
            }
            else if (CMBLocations.SelectedItem.ToString() == "Mars Outpost")
            {
                // If they select the mars outpost we can update the story label to reflect that
                lblStory.Text = "You are now at the Mars outpost. You see a research lab where scientists are studying the planet and a mining area where workers are extracting resources.";
                // Let's change the background image to refelect the Outpost location
                this.BackgroundImage = Properties.Resources.MarsHotelBG_1;
            }
        }
        

        private void TitleFlyer_Click(object sender, EventArgs e)
        {

        }
    }
}
