using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpointsConnect : MonoBehaviour
{
    public Transform[] points;
    public int[] AreaToPoint;
    public static int[] areaToPoint;

    void Start() {
        areaToPoint = AreaToPoint;
    }

    var Road = new Dictionary<int[], int[]>();
    int[] tmp1 = new int[] {0, 1};
    int[] tmp2 = new int[] { 1 };
    Road.Add(tmp1, tmp2);


    public static string[,] Connect = new string[6, 6]
    {
        {
            "", "1", "1,2", "1,2,3", "1,2,3,4", "1,2,3,4,5"
        },
        {
            "0", "", "2", "2,3", "2,3,4", "2,3,4,5"
        },
        {
            "1,0", "1", "", "3", "3,4", "3,4,5"
        },
        {
            "2,1,0", "2,1", "2", "", "4", "4,5"
        },
        {
            "3,2,1,0", "3,2,1", "3,2", "3", "", "5"
        },
        {
            "4,3,2,1,0", "4,3,2,1", "4,3,2", "4,3", "4", ""
        }
    };


}
