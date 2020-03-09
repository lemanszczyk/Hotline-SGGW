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

    public int maxAmmo = 3;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    GameObject[] Enemies;

    void Start()
    {
        currentAmmo = maxAmmo;
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (isReloading)
            return;

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        } 
        //kiedy naciskamy przycisk myszki
        if (Input.GetButtonDown("Fire1") && !PauseMenu.GameIsPause)
        {
            Shoot();
            StartCoroutine(AlarmEnemies());
        }
    }
    
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("reload");
        yield return new WaitForSeconds(reloadTime);

        currentAmmo = maxAmmo;
        isReloading = false;
    }
    //podczas stzelania
    void Shoot()
    {
        currentAmmo--;
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
