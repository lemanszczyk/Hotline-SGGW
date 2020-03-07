using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpointsConnect : MonoBehaviour
{
    public Transform[] points;
    public static Transform[] Points;
    public int[] AreaToPoint;
    public static int[] areaToPoint;

    public static Dictionary<string, int[]> Road = new Dictionary<string, int[]>();
    //public static Dictionary<string, int> road = new Dictionary<string, int>();

    void Start() {
        areaToPoint = AreaToPoint;
        Points = points;

        Road.Clear();

        Road.Add("0,1", new int[] { 1 });
        Road.Add("0,2", new int[] { 1, 2 });
        Road.Add("0,3", new int[] { 1, 2, 3 });
        Road.Add("0,4", new int[] { 1, 2, 3, 4 });
        Road.Add("0,5", new int[] { 1, 2, 3, 4, 5});
        Road.Add("0,6", new int[] { 1, 2, 3, 4, 5, 6 });
        Road.Add("0,7", new int[] { 1, 2, 3, 4, 5, 7 });
        Road.Add("0,8", new int[] { 1, 2, 3, 4, 5, 7, 8 });
        Road.Add("0,9", new int[] { 1, 2, 3, 4, 5, 7, 8, 9 });
        Road.Add("0,10", new int[] { 1, 2, 3, 4, 5, 10 });
        Road.Add("0,11", new int[] { 1, 2, 3, 4, 5, 10, 11 });

        Road.Add("1,0", new int[] { 0 });
        Road.Add("1,2", new int[] { 2 });
        Road.Add("1,3", new int[] { 2, 3 });
        Road.Add("1,4", new int[] { 2, 3, 4 });
        Road.Add("1,5", new int[] { 2, 3, 4, 5 });
        Road.Add("1,6", new int[] { 2, 3, 4, 5, 6 });
        Road.Add("1,7", new int[] { 2, 3, 4, 5, 7 });
        Road.Add("1,8", new int[] { 2, 3, 4, 5, 7, 8 });
        Road.Add("1,9", new int[] { 2, 3, 4, 5, 7, 8, 9 });
        Road.Add("1,10", new int[] { 2, 3, 4, 5, 10 });
        Road.Add("1,11", new int[] { 2, 3, 4, 5, 10, 11 });

        Road.Add("2,0", new int[] { 1, 0 });
        Road.Add("2,1", new int[] { 1 });
        Road.Add("2,3", new int[] { 3 });
        Road.Add("2,4", new int[] { 3, 4 });
        Road.Add("2,5", new int[] { 3, 4, 5 });
        Road.Add("2,6", new int[] { 3, 4, 5, 6 });
        Road.Add("2,7", new int[] { 3, 4, 5, 7 });
        Road.Add("2,8", new int[] { 3, 4, 5, 7, 8 });
        Road.Add("2,9", new int[] { 3, 4, 5, 7, 8, 9 });
        Road.Add("2,10", new int[] { 3, 4, 5, 10 });
        Road.Add("2,11", new int[] { 3, 4, 5, 10, 11 });

        Road.Add("3,0", new int[] { 2, 1, 0 });
        Road.Add("3,1", new int[] { 2, 1 });
        Road.Add("3,2", new int[] { 2 });
        Road.Add("3,4", new int[] { 4 });
        Road.Add("3,5", new int[] { 4, 5 });
        Road.Add("3,6", new int[] { 4, 5, 6 });
        Road.Add("3,7", new int[] { 4, 5, 7 });
        Road.Add("3,8", new int[] { 4, 5, 7, 8 });
        Road.Add("3,9", new int[] { 4, 5, 7, 8, 9 });
        Road.Add("3,10", new int[] { 4, 5, 10 });
        Road.Add("3,11", new int[] { 4, 5, 10, 11 });

        Road.Add("4,0", new int[] { 3, 2, 1, 0 });
        Road.Add("4,1", new int[] { 3, 2, 1 });
        Road.Add("4,2", new int[] { 3, 2 });
        Road.Add("4,3", new int[] { 3 });
        Road.Add("4,5", new int[] { 5 });
        Road.Add("4,6", new int[] { 5, 6 });
        Road.Add("4,7", new int[] { 5, 7 });
        Road.Add("4,8", new int[] { 5, 7, 8 });
        Road.Add("4,9", new int[] { 5, 7, 8, 9 });
        Road.Add("4,10", new int[] { 5, 10 });
        Road.Add("4,11", new int[] { 5, 10, 11 });

        Road.Add("5,0", new int[] { 4, 3, 2, 1, 0 });
        Road.Add("5,1", new int[] { 4, 3, 2, 1 });
        Road.Add("5,2", new int[] { 4, 3, 2 });
        Road.Add("5,3", new int[] { 4, 3 });
        Road.Add("5,4", new int[] { 4 });
        Road.Add("5,6", new int[] { 6 });
        Road.Add("5,7", new int[] { 7 });
        Road.Add("5,8", new int[] { 7, 8 });
        Road.Add("5,9", new int[] { 7, 8, 9 });
        Road.Add("5,10", new int[] { 10 });
        Road.Add("5,11", new int[] { 10, 11 });

        Road.Add("6,0", new int[] { 5, 4, 3, 2, 1, 0 });
        Road.Add("6,1", new int[] { 5, 4, 3, 2, 1 });
        Road.Add("6,2", new int[] { 5, 4, 3, 2 });
        Road.Add("6,3", new int[] { 5, 4, 3 });
        Road.Add("6,4", new int[] { 5, 4 });
        Road.Add("6,5", new int[] { 5 });
        Road.Add("6,7", new int[] { 7 });
        Road.Add("6,8", new int[] { 7, 8 });
        Road.Add("6,9", new int[] { 7, 8, 9 });
        Road.Add("6,10", new int[] { 10 });
        Road.Add("6,11", new int[] { 10, 11 });

        Road.Add("7,0", new int[] { 5, 4, 3, 2, 1, 0 });
        Road.Add("7,1", new int[] { 5, 4, 3, 2, 1 });
        Road.Add("7,2", new int[] { 5, 4, 3, 2 });
        Road.Add("7,3", new int[] { 5, 4, 3 });
        Road.Add("7,4", new int[] { 5, 4 });
        Road.Add("7,5", new int[] { 5 });
        Road.Add("7,6", new int[] { 6 });
        Road.Add("7,8", new int[] { 8 });
        Road.Add("7,9", new int[] { 8, 9 });
        Road.Add("7,10", new int[] { 6, 10 });
        Road.Add("7,11", new int[] { 6, 10, 11 });

        Road.Add("8,0", new int[] { 7, 5, 4, 3, 2, 1, 0 });
        Road.Add("8,1", new int[] { 7, 5, 4, 3, 2, 1 });
        Road.Add("8,2", new int[] { 7, 5, 4, 3, 2 });
        Road.Add("8,3", new int[] { 7, 5, 4, 3 });
        Road.Add("8,4", new int[] { 7, 5, 4 });
        Road.Add("8,5", new int[] { 7, 5 });
        Road.Add("8,6", new int[] { 7, 6 });
        Road.Add("8,7", new int[] { 7 });
        Road.Add("8,9", new int[] { 9 });
        Road.Add("8,10", new int[] { 7, 6, 10 });
        Road.Add("8,11", new int[] { 7, 6, 10, 11 });

        Road.Add("9,0", new int[] { 8, 7, 5, 4, 3, 2, 1, 0 });
        Road.Add("9,1", new int[] { 8, 7, 5, 4, 3, 2, 1 });
        Road.Add("9,2", new int[] { 8, 7, 5, 4, 3, 2 });
        Road.Add("9,3", new int[] { 8, 7, 5, 4, 3 });
        Road.Add("9,4", new int[] { 8, 7, 5, 4 });
        Road.Add("9,5", new int[] { 8, 7, 5 });
        Road.Add("9,6", new int[] { 8, 7, 6 });
        Road.Add("9,7", new int[] { 8, 7 });
        Road.Add("9,8", new int[] { 8 });
        Road.Add("9,10", new int[] { 8, 7, 6, 10 });
        Road.Add("9,11", new int[] { 8, 7, 6, 10, 11 });

        Road.Add("10,0", new int[] { 5, 4, 3, 2, 1, 0 });
        Road.Add("10,1", new int[] { 5, 4, 3, 2, 1 });
        Road.Add("10,2", new int[] { 5, 4, 3, 2 });
        Road.Add("10,3", new int[] { 5, 4, 3 });
        Road.Add("10,4", new int[] { 5, 4 });
        Road.Add("10,5", new int[] { 5 });
        Road.Add("10,6", new int[] { 6 });
        Road.Add("10,7", new int[] { 6, 7 });
        Road.Add("10,8", new int[] { 6, 7, 8 });
        Road.Add("10,9", new int[] { 6, 7, 8, 9 });
        Road.Add("10,11", new int[] { 11 });

        Road.Add("11,0", new int[] { 10, 5, 4, 3, 2, 1, 0 });
        Road.Add("11,1", new int[] { 10, 5, 4, 3, 2, 1 });
        Road.Add("11,2", new int[] { 10, 5, 4, 3, 2 });
        Road.Add("11,3", new int[] { 10, 5, 4, 3 });
        Road.Add("11,4", new int[] { 10, 5, 4 });
        Road.Add("11,5", new int[] { 10, 5 });
        Road.Add("11,6", new int[] { 10, 6 });
        Road.Add("11,7", new int[] { 10, 6, 7 });
        Road.Add("11,8", new int[] { 10, 6, 7, 8 });
        Road.Add("11,9", new int[] { 10, 6, 7, 8, 9 });
        Road.Add("11,10", new int[] { 10 });

        //Debug.Log(AIpointsConnect.Road[new int[] { 0, 3 }]);

        //road.Add("start", 4);
        //Debug.Log(road["start"]);
    }


}
