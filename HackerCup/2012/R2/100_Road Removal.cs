
namespace HackerCup._2012.R2
{
    /*
    https://www.facebook.com/hackercup/problems.php?pid=278355025564990&round=154897681286317

	You are given a network with N cities and M bidirectional roads connecting 
	these cities. The first K cities are important. You need to remove the minimum 
	number of roads such that in the remaining network there are no cycles that 
	contain important cities. A cycle is a sequence of at least three different cities 
	such that each pair of neighboring cities are connected by a road and the first 
	and the last city in the sequence are also connected by a road.

	Input
	The first line contains the number of test cases T.

	Each case begins with a line containing integers N, M and K, which represent the 
	number of cities, the number of roads and the number of important cities, 
	respectively. The cities are numbered from 0 to N-1, and the important cities are 
	numbered from 0 to K-1. The following M lines contain two integers a[i] and b[i], 0 ≤ i < M, 
	that represent two different cities connected by a road.

	It is guaranteed that 0 ≤ a[i], b[i] < N and a[i] ≠ b[i]. There will be at most 
	one road between two cities.

	Output
	For each of the test cases numbered in order from 1 to T, output 
	"Case #i: " followed by a single integer, the minimum number of roads that need 
	to be removed such that there are no cycles that contain an important city.

	Constraints
	1 ≤ T ≤ 20
	1 ≤ N ≤ 10000
	1 ≤ M ≤ 50000
	1 ≤ K ≤ N

	Example
	In the first example, we have N=5 cities that are connected by M=7 roads and 
	the cities 0 and 1 are important. We can remove two roads connecting (0, 1) and (1, 2) 
	and the remaining network will not contain cycles with important cities. Note that 
	in the remaining network there is a cycle that contains only non-important cities, 
	and that there are also multiple ways to remove two roads and satisfy all conditions. 
	One cannot remove only one road and destroy all cycles that contain important cities.
	
    */
    public class RoadRemoval : IExecutable
    {
        public string[] Execute(params string[] input)
        {
			return null;
        }
    }
}
