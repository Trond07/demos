using System.Drawing;   // For Color class

namespace DemoMembers
{
    public class FootballTeam
    {
        // Fields
        private string name;                 
        private Color jerseyColor;           
        private int wins, draws, defeats;  
        private bool logging;

        // Constructor.
        public FootballTeam(string n, Color j)
        {
            name = n;
            jerseyColor = j;
        }

        // Read-only property to get the team name.
        public string Name
        {
            get { return name; }
        }

        // Read-only property to calculate points earned.
        public int Points
        {
            get { return (wins * 3) + (draws * 1) + (defeats * 0); }
        }

        // Read-write property to get and set jersey color
        public Color JerseyColor
        {
            get
            {
                return jerseyColor;
            }
            set
            {
                if (value == Color.Black)
                {
                    throw new ArgumentException("Cannot have black jerseys");
                }
                jerseyColor = value;
            }
        }

        // Write-only property to enable/disable logging.
        public bool Logging
        {
            set { logging = value; }
        }

        // Private read-only property, to get FileStream for logging.
        private FileStream LogStream
        {
            get
            {
                try
                {
                    return new FileStream(name + ".log", FileMode.Append, FileAccess.Write);
                }
                catch (Exception)
                {
                    return new FileStream("Default.log", FileMode.Append, FileAccess.Write);
                }
            }
        }

        // Method to enter the result of a game.
        public void PlayGame(string opponent, int goalsFor, int goalsAgainst)
        {
            // Increment the appropriate counter.
            if (goalsFor > goalsAgainst)
                wins++;
            else if (goalsFor == goalsAgainst)
                draws++;
            else
                defeats++;

            // If logging is enabled, log result to file.
            if (logging)
            {
                StreamWriter writer = new StreamWriter(LogStream);
                writer.WriteLine("{0} {1}-{2} {3}", name, goalsFor, goalsAgainst, opponent);
                writer.Flush();
                writer.Close();
            }
        }
    }


    // -----------------------------------------------------
    // Client code to test the FootballTeam class.
    // -----------------------------------------------------
    static class ReadOnlyWriteOnlyPropertiesDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nReadOnlyWriteOnlyPropertiesDemo");
            Console.WriteLine("------------------------------------------------------");

            // Create a FootballTeam object.
            FootballTeam myTeam = new FootballTeam("Swansea", Color.White);

            // Use Name read-only property.
            Console.WriteLine($"Team: {myTeam.Name}");

            // Use JerseyColor read-write property.
            myTeam.JerseyColor = Color.Red;
            Console.WriteLine($"Jersey: {myTeam.JerseyColor}");

            // Use Logging write-only property.
            myTeam.Logging = true;

            // Play some games. 
            myTeam.PlayGame("Liverpool", 1, 1);
            myTeam.PlayGame("Chelsea", 3, 1);
            myTeam.PlayGame("Manchester United", 0, 4);
            myTeam.PlayGame("Everton", 2, 0);

            // Use Points property to calculate points earned
            Console.WriteLine($"Points: {myTeam.Points}");
        }
    }
}

