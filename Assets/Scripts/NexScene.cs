using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NexScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D player;
    public int id_scen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>() == player)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(id_scen);
        }
    }
}
