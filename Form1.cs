/*Opening Comment - The program should show the images of four random playing cards without replacement (meaning no card should be shown
twice in the same draw.) The program should also append the cards drawn categorized by date to a text file. The date should 
be in MM/DD/YYYY format.The programming language Group 4 is using is C# with WinForms .NET application builder. The IDE used by
Chelsie is Visual Studio. Group 4 consists of Jack Elliott, Haley Laguna, Jonny Stadter, Paul Williams, and Chelsie Wilson.
Team Lead: Jack Elliott
Programmer: Chelsie Wilson
Scribe: Jonny Stadter
Designer: Paul Williams

Haley Laguna has not engaged with the group

Ouside Resources used by CW - microsoft.com/en-us/dotnet/csharp/misc/cs1503, Coding Homework Channel on Youtube (ideas on how to shuffle card deck),
https://www.youtube.com/watch?v=NOkBUoP54b8 


User Manual compilation, build and execution istructions....*/

namespace Cards._3
{
    public partial class Form1 : Form
    {

       

        //lists and arrays to hold card images (CW and JE)
        public List<Card> deck = new List<Card>();
        public PictureBox[] pictureBoxes = new PictureBox[4];

        public Form1()
        {
            //Initialize all components on the form and create pictureboxes to hold card images (CW)
            InitializeComponent();
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            deck = makeDeck();

            //populate date when program first runs so that the loop for card generateion can append each hand to the date (CW)
            using (StreamWriter sw = File.AppendText("./CardsDealt.txt"))
            {
                sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

            }
        }

        //Function to populate a full deck of cards. This creates a List of Card objects, so we can later dynamically add/remove cards for the selection without replacement
        static List<Card> makeDeck() //funcion by JE
        {
            List<Card> deck = new List<Card>();
            string[] suits = { "_of_diamonds", "_of_hearts", "_of_spades", "_of_clubs" };
            string[] logSuits = { "D", "H", "S", "C" };
            string[] logRanks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" };
            string[] rankNames = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            //Iterates through the four suits (JE)
            for (int i = 0; i < 4; i++)
            {
                //Populates each suit with 2 through 14, or the proper log rank, or the rank name (JE)
                for (int j = 0; j < 13; j++)
                {
                    //string fP = j + suits[i];
                    //string l = logRanks[j - 2] + logSuits[i];
                    deck.Add(new Card(suits[i], logSuits[i], logRanks[j], rankNames[j]));
                }
            }
            return deck;
        }


        /*Deal Button click fuction that will iterate through a loop 4 times to return random card images to pictureBox1. It could also append
        the 4 cards to the text file if we keep track of each card drawn while within the loop. 
        The deal button can be pressed as many times as the user wants to deal 4 new card images each time (CW)*/

        private void dealButton_Click(object sender, EventArgs e)
        {
            {
                Random random = new Random();

                //Used to export to text logging method (JE)
                Card[] hand = new Card[4];

                using (StreamWriter sw = File.AppendText("./CardsDealt.txt"))
                {

                    //Loop to iterate 4 times and generate 4 random card images and titles (JE)
                    for (int i = 0; i < 4; i++)
                    {
                        // Generate a random index within the remaining cards in the deck (JE)
                        int index = random.Next(0, deck.Count - 1);
                        hand[i] = deck[index];
                        deck.RemoveAt(index);


                        //get card images from the file (CW)
                        var img = System.Drawing.Image.FromFile("./playingcards/" + hand[i].getName());
                        pictureBoxes[i].Image = img;

                        //make the card images sizable to the pictureboxes (CW)
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    //write the cards in each hand to the CardsDealt.txt file (CW)
                    sw.WriteLine(hand[0].rankName + hand[0].suit + "," +
                        hand[1].rankName + hand[1].suit + "," +
                        hand[2].rankName + hand[2].suit + "," +
                        hand[3].rankName + hand[3].suit);
                }
            }
        }


    }
    //Card class, all functions use this.(JE)
    public class Card
    {
        public string suit { get; set; }

        public string suitSuffix { get; set; }
        public string rank { get; set; }

        public string rankName { get; set; }

        public Card(string aSuitSuffix, string aSuit, string aRank, string aRankName)
        {
            suitSuffix = aSuitSuffix;
            suit = aSuit;
            rank = aRank;
            rankName = aRankName;
        }

        //returns the required information from the file name for the text file (CW)
        public string getName()
        {
            return rank + suitSuffix + ".png";
        }
    }
    //quit button code is encoded in the designer code for the quit button component (CW)
}