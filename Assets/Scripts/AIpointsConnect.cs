using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpointsConnect : MonoBehaviour
{
    public Transform[] points;
    public static Transform[] Points;
    public int[] AreaToPoint;
    public static int[] areaToPoint;

    public static Dictionary<int[], int> Road = new Dictionary<int[], int>();

    void Start() {
        areaToPoint = AreaToPoint;
        Points = points;

        Road.Add(new int[] { 0, 1 }, 1);
        Road.Add(new int[] { 0, 2 }, 1);
        Road.Add(new int[] { 0, 3 }, 1);
        Road.Add(new int[] { 0, 4 }, 1);
        Road.Add(new int[] { 0, 5 }, 1);
        Road.Add(new int[] { 0, 6 }, 1);

        Road.Add(new int[] { 1, 0 }, 0);
        Road.Add(new int[] { 1, 2 }, 2);
        Road.Add(new int[] { 1, 3 }, 2);
        Road.Add(new int[] { 1, 4 }, 2);
        Road.Add(new int[] { 1, 5 }, 2);
        Road.Add(new int[] { 1, 6 }, 2);

        Road.Add(new int[] { 2, 0 }, 1);
        Road.Add(new int[] { 2, 1 }, 1);
        Road.Add(new int[] { 2, 3 }, 3);
        Road.Add(new int[] { 2, 4 }, 3);
        Road.Add(new int[] { 2, 5 }, 3);
        Road.Add(new int[] { 2, 6 }, 3);

        Road.Add(new int[] { 3, 0 }, 2);
        Road.Add(new int[] { 3, 1 }, 2);
        Road.Add(new int[] { 3, 2 }, 2);
        Road.Add(new int[] { 3, 4 }, 4);
        Road.Add(new int[] { 3, 5 }, 4);
        Road.Add(new int[] { 3, 6 }, 4);

        Road.Add(new int[] { 4, 0 }, 3);
        Road.Add(new int[] { 4, 1 }, 3);
        Road.Add(new int[] { 4, 2 }, 3);
        Road.Add(new int[] { 4, 3 }, 3);
        Road.Add(new int[] { 4, 5 }, 5);
        Road.Add(new int[] { 4, 6 }, 5);

        Road.Add(new int[] { 5, 0 }, 4);
        Road.Add(new int[] { 5, 1 }, 4);
        Road.Add(new int[] { 5, 2 }, 4);
        Road.Add(new int[] { 5, 3 }, 4);
        Road.Add(new int[] { 5, 4 }, 4);
        Road.Add(new int[] { 5, 6 }, 6);
        
        Road.Add(new int[] { 6, 0 }, 5);
        Road.Add(new int[] { 6, 1 }, 5);
        Road.Add(new int[] { 6, 2 }, 5);
        Road.Add(new int[] { 6, 3 }, 5);
        Road.Add(new int[] { 6, 4 }, 5);
        Road.Add(new int[] { 6, 5 }, 5);

        Debug.Log(AIpointsConnect.Road[new int[] { 0, 3 }]);
    }


}
