using System;
using System.Collections.Generic;
using System.Linq;

namespace HighOrLower.library
{
    public class LeaderBoard
    {
        List<Score> scores = new List<Score>();

        public void AddScore(string username, int points)
        {
            scores.Add(new Score { Username = username, Points = points});
        }

        public List<Score> GetAll()
        {
            
            return scores.OrderByDescending(i => i.Points).ToList();
        }
    }
}
