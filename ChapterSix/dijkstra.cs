//the first thing we gonna make the graph methode that contains the total number of the node and how many road and the starting point.
//a list show all the roads and the time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //the graph methode
    public class City
    {
        private Dictionary <int ,List<( int ,int)>> adjlist;
        private int intersections;
        public City(int intersections)
        {
            this.intersections = intersections;
            this.adjlist = new Dictionary<int, List<(int, int)>>();
            for (int i = 0; i < intersections; i++)
            {
                adjlist[i] = new List<(int, int)>();
            }

        }
        public void AddRoad(int startpoint ,int nextpoint ,int time)
        {
            adjlist[startpoint].Add((nextpoint, time));

        }
        //dijkstra methode
        public List<int> ShortestTime (int startpoint) {
            var times=new int[intersections];
            var visited = new bool[intersections];
            for (int i = 0; i < intersections; i++)
            {
                times[i] = int.MaxValue;                
            }
                times[startpoint] = 0;  
            //to find reachable node shortest way
            for (int i = 0; i < intersections; i++)
            {
               int current = findUnvisited(times, visited);
                if (current == -1)
                {
                    break;
                }
                visited[current] = true;
                foreach (var (neibhor,travelTime) in adjlist[current])
                {
                    if (!visited[neibhor])
                    {
                      int newTime = times[current] + travelTime; 
                      if (newTime < times[neibhor])
                      {
                        times[neibhor] = newTime;
                      }  
                    }
                    
                }
                
            }
            return new List<int>(times);
        }
        //find the unvisited and updating the shortest time
        public int findUnvisited(int[] times, bool[] visited)
        {
            int minTime = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < intersections; i++)
            {
                if (visited[i] && times[i] < minTime)
                {
                    minTime = times[i];
                    minIndex = i;
                }
              
                
            }
            return minIndex;
        }

    }
}