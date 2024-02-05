//Opening Comment - The program should show the images of four random playing cards without replacement (meaning no card should be shown
//twice in the same draw.) The program should also append the cards drawn categorized by date to a text file. The date should 
//be in MM/DD/YYYY format.The programming language Group 4 is using is C# with WinForms .NET application builder. The IDE used by
//Chelsie is Visual Studio. Group 4 consists of Jack Elliott, Haley Laguna, Jonny Stadter, Paul Williams, and Chelsie Wilson.
//Team Lead: Jack Elliott
//Programmer: Chelsie Wilson
//Scribe: Jonny
//Designer: Paul Williams

//Ouside Resources used by CW - microsoft.com/en-us/dotnet/csharp/misc/cs1503, Coding Homework Channel on Youtube (ideas on how to shuffle card deck) 

//User Manual compilation, build and execution istructions....

namespace Cards._3
{
    public partial class Form1 : Form
    {
        //File Path to playing cards. This gives us the playing card images (CW)
        private string images = "PlayingCards"; //give filepath here

        // Arry to correspond to each card in the file to help with appending the cards drawn to the text file (CW)
        private string[] cards = new string[]
        {
            "Ace_of_Spades.png", "2_of_Spades.png", "3_of_Spades.png", "4_of_Spades.png", "5_of_Spades.png", "6_of_Spades.png", "7_of_Spades.png", "8_of_Spades.png", "9_of_Spades.png", "10_of_Spades.png", "Jack_of_Spades.png", "Queen_of_Spades.png", "King_of_Spades.png",
            "Ace_of_Hearts.png", "2_of_Hearts.png", "3_of_Hearts.png", "4_of_Hearts.png", "5_of_Hearts.png", "6_of_Hearts.png", "7_of_Hearts.png", "8_of_Hearts.png", "9_of_Hearts.png", "10_of_Hearts.png", "Jack_of_Hearts.png", "Queen_of_Hearts.png", "King_of_Hearts.png",
            "Ace_of_Diamonds.png", "2_of_Diamonds.png", "3_of_Diamonds.png", "4_of_Diamonds.png", "5_of_Diamonds.png", "6_of_Diamonds.png", "7_of_Diamonds.png", "8_of_Diamonds.png", "9_of_Diamonds.png", "10_of_Diamonds.png", "Jack_of_Diamonds.png", "Queen_of_Diamonds.png", "King_of_Diamonds.png",
            "Ace_of_Clubs.png", "2_of_Clubs.png", "3_of_Clubs.png", "4_of_Clubs.png", "5_of_Clubs.png", "6_of_Clubs.png", "7_of_Clubs.png", "8_of_Clubs.png", "9_of_Clubs.png", "10_of_Clubs.png", "Jack_of_Clubs.png", "Queen_of_Clubs.png", "King_of_Clubs.png"
        };

        //Turn card image names into text file format - (e.g. 10H, 2D, 4C...) NO BLANKS in text file - Date above all entries
        //on separate lines for that date

        // Random number generator (CW)
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        //Deal Button click fuction that will iterate through a loop 4 times to return random card images to pictureBox1. It could also append
        //the 4 cards to the text file if we keep track of each card drawn while within the loop. (CW)
        //The deal button can be pressed as many times as the user wants to deal 4 new card images each time
        private void dealButton_Click(object sender, EventArgs e)
        {
            //Loop to iterate 4 times and generate 4 random card images and titles (CW)
            for (int i = 0; i < 4; i++)
            {
                // Generate a random index within the remaining cards in the deck
                int index = random.Next(0, cards.Length - i);

                // Get the file path of the card image
                string cardImages = Path.Combine("Playing Cards", cards[index]);

                // Load the card image into a PictureBox
                PictureBox pictureBox = new PictureBox
                {
                  
                    Image = System.Drawing.Image.FromFile(cardImages),
                    Width = 250, //this can be modified if needed to accommodate all the card images
                    Height = 150,//this can be modified if needed to accommodate all the card images
                };

                //Take card out of deck to meet without replacement criteria
                
            }
        }

        //The below function will close out the program completely. 
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}