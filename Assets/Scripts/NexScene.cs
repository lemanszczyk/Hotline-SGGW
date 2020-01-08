using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

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
        EditorSceneManager.LoadScene(id_scen);
    }
}
