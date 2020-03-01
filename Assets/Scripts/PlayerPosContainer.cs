using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosContainer : MonoBehaviour
{
    public static int areaNumber = 0;

    public static void ChangeArea(int area)
    {
        areaNumber = area;
        Debug.Log(area);
    }
}
