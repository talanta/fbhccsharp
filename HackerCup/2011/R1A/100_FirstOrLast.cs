using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2011.R1A
{
    /*
    As a top driver in European racing circles, you find yourself taking more than
    your fair share of risks. You go into every race knowing it may be your last,
    but generally with the suspicion it won't be. Today, however, may turn out to
    be different. The Fédération Internationale de l'Automobile has sanctioned a
    new track in the Bernese Alps that may prove to be death of anyone that dares
    brave its tight, awkwardly-banked turns and cliff-adjacent straightaways.

    Since you are a professional racing driver, you have considerable financial
    backing and support in preparing for your first race on this new course. A veritable
    consortium of physicists, software engineers, and drivers more expendable than
    yourself have determined, for each corner on the track, the probability of crashing
    during normal fast-paced driving and the probability of crashing during an overtake
    maneuver. A single crash will end the race for you. It is left to you to use this
    information to formulate your overall racing strategy.

    The race you will participate in will include R racers including yourself. Given
    your history of apparently effortlessly cruising past all opponents to victory,
    you will be starting at the rear of the pack to keep things interesting. You must
    use your knowledge of the track to get to first place by the time you have passed
    through the final turn. You can only overtake opponents during a turn, so you must
    choose the R-1 turns during which to overtake that will maximize your likelihood
    of finishing the race. This isn't the charitable sort of racing that awards accolades
    like "second place", so your only goal here is to defeat every single opponent.

    Input
    Your input file will begin with a single integer N, the number of test cases to
    follow, followed by a newline. Each test case begins with a single line containing
    two integers, R as specified above and T, the number of turns on the track. Following
    this will be T pairs of integers where the ith pair represents the likelihood of
    crashing while overtaking and the likelihood of crashing during normal driving,
    respectively during the ith turn. For each of these integers p, consider the probability
    of the corresponding event to be 1/p.

    Output
    Output, for each test case, the reduced fraction representing the probability
    that you will win the race. Your outputs should be separated only by whitespace.

    Constraints

    10 <= N <= 30 1 <= T <= 50 1 <= R < T
    1 <= p <= 500
    */
    public class FirstOrLast : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
