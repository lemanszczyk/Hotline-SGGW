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

        Road.Add("1,0", new int[] { 0 });
        Road.Add("1,2", new int[] { 2 });
        Road.Add("1,3", new int[] { 2, 3 });
        Road.Add("1,4", new int[] { 2, 3, 4 });
        Road.Add("1,5", new int[] { 2, 3, 4, 5 });
        Road.Add("1,6", new int[] { 2, 3, 4, 5, 6 });

        Road.Add("2,0", new int[] { 1, 0 });
        Road.Add("2,1", new int[] { 1 });
        Road.Add("2,3", new int[] { 3 });
        Road.Add("2,4", new int[] { 3, 4 });
        Road.Add("2,5", new int[] { 3, 4, 5 });
        Road.Add("2,6", new int[] { 3, 4, 5, 6 });

        Road.Add("3,0", new int[] { 2, 1, 0 });
        Road.Add("3,1", new int[] { 2, 1 });
        Road.Add("3,2", new int[] { 2 });
        Road.Add("3,4", new int[] { 4 });
        Road.Add("3,5", new int[] { 4, 5 });
        Road.Add("3,6", new int[] { 4, 5, 6 });

        Road.Add("4,0", new int[] { 3, 2, 1, 0 });
        Road.Add("4,1", new int[] { 3, 2, 1 });
        Road.Add("4,2", new int[] { 3, 2 });
        Road.Add("4,3", new int[] { 3 });
        Road.Add("4,5", new int[] { 5 });
        Road.Add("4,6", new int[] { 5, 6 });

        Road.Add("5,0", new int[] { 4, 3, 2, 1, 0 });
        Road.Add("5,1", new int[] { 4, 3, 2, 1 });
        Road.Add("5,2", new int[] { 4, 3, 2 });
        Road.Add("5,3", new int[] { 4, 3 });
        Road.Add("5,4", new int[] { 4 });
        Road.Add("5,6", new int[] { 6 });
        
        Road.Add("6,0", new int[] { 5, 4, 3, 2, 1, 0 });
        Road.Add("6,1", new int[] { 5, 4, 3, 2, 1 });
        Road.Add("6,2", new int[] { 5, 4, 3, 2 });
        Road.Add("6,3", new int[] { 5, 4, 3 });
        Road.Add("6,4", new int[] { 5, 4 });
        Road.Add("6,5", new int[] { 5 });

        //Debug.Log(AIpointsConnect.Road[new int[] { 0, 3 }]);

        //road.Add("start", 4);
        //Debug.Log(road["start"]);
    }


}
