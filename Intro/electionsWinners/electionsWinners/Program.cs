using System;
using System.Linq;

namespace electionsWinners
{
    // Elections are in progress!
    //Given an array of the numbers of votes given to each of the candidates so far, 
    //and an integer k equal to the number of voters who haven't cast their vote yet, 
    //find the number of candidates who still have a chance to win the election.

    //The winner of the election must secure strictly more votes than any other candidate.
    //If two or more candidates receive the same (maximum) number of votes, assume there is
    //no winner at all.
    class Program
    {
        static void Main(string[] args)
        {
            int[] votes = { 2, 3, 5, 2 };
            int k = 3;
            Console.WriteLine(electionsWinners(votes,k));
        }

        static int electionsWinners(int[] votes, int k)
        {

            int maxVotes = votes.Max();
            int countmaxVotes = votes.Where(x => x == maxVotes).Select(x => x).Count();

            if (k == 0 && countmaxVotes == 1)
                return 1;

            int countOfWinner = 0;
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] + k > maxVotes)
                    countOfWinner++;
            }
            return countOfWinner;
        }

    }
}
