using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    //z którego miejsca strzelać
    public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        //kiedy naciskamy przycisk myszki
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    //podczas stzelania
    void Shoot()
    {
        //tworzenie pocisku
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Debug.Log(firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //dodawanie siły do pocisku
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
