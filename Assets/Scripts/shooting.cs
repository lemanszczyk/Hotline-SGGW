using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    //z którego miejsca strzelać
    
    public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public float SoundRange = 10;

    GameObject[] Enemies;

    void Start()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        //kiedy naciskamy przycisk myszki
        if (Input.GetButtonDown("Fire1") && !PauseMenu.GameIsPause)
        {
            Shoot();
            StartCoroutine(AlarmEnemies());
        }
    }
    //podczas stzelania
    void Shoot()
    {
        //tworzenie pocisku
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //Debug.Log(firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //dodawanie siły do pocisku
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    IEnumerator AlarmEnemies()
    {
        yield return new WaitForSeconds(0.25f);
        for (int i = 0; i < Enemies.Length; i++)
        {
            if (Vector2.Distance(transform.position, Enemies[i].transform.position) <= SoundRange)
            {
                Enemies[i].GetComponent<EnemyBehaviour>().InformEnemy();
            }
        }
    }
}
