using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2011.R1A
{
    /*
    Walking home in triumph after a particularly satisfying dance battle, you take
    a wrong turn into an alley and find yourself presented with a perplexing puzzle.
    The entrance to the alley behind you disappears and you are faced with a rectangular
    grid of colorful squares, with thick granite walls occupying some of the squares.
    The grid is recessed far enough into the ground that, from above, you can see the
    exit in the distance and the layout of all the colors. You can memorize the entire
    layout before entering the grid and trying to make your way across.

    As you stand above the grid trying to commit its layout to memory, you notice
    something strange about the urban wildlife trapped with you in the maze; the
    various fauna seem to be able to move almost instantaneously between squares
    of the same color. You suspect that you can use this property to your advantage,
    which you attempt to keep at the front of your mind as you enter the labyrinth
    with your intentions set on getting out as quickly as possible.

    Input

    Your input file will consist of a number N followed by some whitespace and
    then N test cases. Each case consists of two numbers R and C, the number of
    rows and columns in the maze, followed by R strings describing the layout of
    the rows in order. All tokens are whitespace-separated.

    Each element describing a row will consist of the characters 'S', 'E', 'W', or
    the digits 0-9. There will be only one 'S' square and one 'E' square, 'S' being
    your starting point and 'E' being the exit. 'S' will be in the first row, 'E' will
    be in the last row. 'W' squares are occupied by walls, and cannot be entered.
    Digits 1-9 represent the colors of the squares. You can pass in a single step
    between adjacent squares or between any two squares of the same color. The start
    and exit points as well as all '0' squares are inert, i.e., they have no color
    and must be stepped directly on to or off of. There will always be some valid
    method of reaching the exit.

    Output

    Return the number of steps required to reach the exit from the starting point.
    */
    public class AfterTheDanceBattle : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
