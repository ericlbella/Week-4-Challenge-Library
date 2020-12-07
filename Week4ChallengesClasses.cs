using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenge_Library
{
   public abstract class VideoGame
    {
        string GameName { get; set; }
        string MaturityRating { get; set; }
        string GameType { get; set; }

       public abstract string PrePlayed();
        
        public VideoGame() { }
        public VideoGame(string gameName, string maturityRating, string gameType)
        {
            GameName = gameName;
            MaturityRating = maturityRating;
            GameType = gameType;
        }

    }

     public class XBoxGame : VideoGame
    {
        public bool WorksWithKinect { get; set; }

        public override string PrePlayed()
        {
                return "XBox Game Has been preplayed.";

        }
        public XBoxGame() { }

        public XBoxGame(bool worksWith_Kinect, string gameName, string maturityRating, string gameType)
            :base(gameName, maturityRating, gameType)
        {
            WorksWithKinect = worksWith_Kinect;
        }

    }

    public class PS5Game : VideoGame
    {
        public bool BackwardsCompatiblePS4 { get; set; } = true;

        public override string PrePlayed()
            {
                return "PS5Game has not been preplayed";
            }

        public PS5Game() { }

        public PS5Game(bool backwardsCompatiblePS4, string gameName, string maturityRating, string gameType)
            : base(gameName, maturityRating, gameType)
        {
            BackwardsCompatiblePS4 = backwardsCompatiblePS4;
        }
    }
}
