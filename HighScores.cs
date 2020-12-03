using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> Data;
    public HighScores(List<int> list) => Data = list;

    public List<int> Scores() => Data;

    public int Latest()
    {
        return Data.Last();
    }

    public int PersonalBest()
    {
        return Data.Max();
    }

    public List<int> PersonalTopThree()
    {
        var maximum = Data.Max();
        if (Data.Count == 1)
        {
            var topThreeNumbers = new List<int> { maximum };
            return topThreeNumbers;
        }
        if (Data.Count == 2)
        {
            var secondMaximum = Data.Where(x => x < maximum).Max();
            var topThreeNumbers = new List<int> { maximum, secondMaximum };
            return topThreeNumbers;
        }
        else
        {
            var secondMaximum = Data.Where(x => x < maximum).Max();
            var thirdMaximum = Data.Where(x => x < secondMaximum).Max();
            var topThreeNumbers = new List<int> { maximum, secondMaximum, thirdMaximum };
            return topThreeNumbers;
        }
        
    }
    
}
