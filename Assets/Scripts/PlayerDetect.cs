using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    [SerializeField] int id;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            PlayerPosContainer.ChangeArea(id);
        }
    }
}
