using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpointsConnect : MonoBehaviour
{
    public Transform[] points;
    public static Transform[] Points;
    public int[] AreaToPoint;
    public static int[] areaToPoint;

    public static Dictionary<string, int> Road = new Dictionary<string, int>();
    //public static Dictionary<string, int> road = new Dictionary<string, int>();

    void Start() {
        areaToPoint = AreaToPoint;
        Points = points;

        Road.Clear();

        Road.Add("0,1", 1);
        Road.Add("0,2", 1);
        Road.Add("0,3", 1);
        Road.Add("0,4", 1);
        Road.Add("0,5", 1);
        Road.Add("0,6", 1);

        Road.Add("1,0", 0);
        Road.Add("1,2", 2);
        Road.Add("1,3", 2);
        Road.Add("1,4", 2);
        Road.Add("1,5", 2);
        Road.Add("1,6", 2);

        Road.Add("2,0", 1);
        Road.Add("2,1", 1);
        Road.Add("2,3", 3);
        Road.Add("2,4", 3);
        Road.Add("2,5", 3);
        Road.Add("2,6", 3);

        Road.Add("3,0", 2);
        Road.Add("3,1", 2);
        Road.Add("3,2", 2);
        Road.Add("3,4", 4);
        Road.Add("3,5", 4);
        Road.Add("3,6", 4);

        Road.Add("4,0", 3);
        Road.Add("4,1", 3);
        Road.Add("4,2", 3);
        Road.Add("4,3", 3);
        Road.Add("4,5", 5);
        Road.Add("4,6", 5);

        Road.Add("5,0", 4);
        Road.Add("5,1", 4);
        Road.Add("5,2", 4);
        Road.Add("5,3", 4);
        Road.Add("5,4", 4);
        Road.Add("5,6", 6);
        
        Road.Add("6,0", 5);
        Road.Add("6,1", 5);
        Road.Add("6,2", 5);
        Road.Add("6,3", 5);
        Road.Add("6,4", 5);
        Road.Add("6,5", 5);

        //Debug.Log(AIpointsConnect.Road[new int[] { 0, 3 }]);

        //road.Add("start", 4);
        //Debug.Log(road["start"]);
    }


}
