using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float maxspeed;
    [SerializeField] float acceleration;
    [SerializeField] Transform playerDisplay;

    Rigidbody2D rb;

    void RotateDisplayToMouse()
    {
        //miejsce które wskazuje myszka
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            //obliczanie kierunku w którym gracz powinien być obrócony
            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Vector2 direction = hit.point - position;
            float newAngle = Vector3.Angle(direction, Vector3.up);
            if (hit.point.x > transform.position.x)
            {
                //Jeśli kąt jest większy od 180 stopni, funkcja Angle zwróci zły wynik. Należy go odjąć od 360
                newAngle = 360 - newAngle;
            }
            //Nowa rotacja gracza
            playerDisplay.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newAngle);
        }
    }

    void Move()
    {
        //Ustalanie chcianej prędkości
        Vector2 vel = rb.velocity;
        Vector2 desiredVel = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        desiredVel *= maxspeed;
        
        //Składowe prędkości, które chcemy ustalić
        float velX, velY;
        if (desiredVel.x >= vel.x)
        {
            //jeśli chciana jest większa od obecnej, zwiększamy prędkość a następnie ograniczamy do chcianej, jeśli wychodzi za duża
            velX = vel.x + acceleration * Time.fixedDeltaTime;
            velX = Mathf.Min(velX, desiredVel.x);
        }
        else
        {
            //jeśli chciana jest mniejsza od obecnej, zmniejszamy prędkość a następnie ograniczamy do chcianej, jeśli wychodzi za mała
            velX = vel.x - acceleration * Time.fixedDeltaTime;
            velX = Mathf.Max(velX, desiredVel.x);
        }
        if (desiredVel.y >= vel.y)
        {
            //jeśli chciana jest większa od obecnej, zwiększamy prędkość a następnie ograniczamy do chcianej, jeśli wychodzi za duża
            velY = vel.y + acceleration * Time.fixedDeltaTime;
            velY = Mathf.Min(velY, desiredVel.y);
        }
        else
        {
            //jeśli chciana jest mniejsza od obecnej, zmniejszamy prędkość a następnie ograniczamy do chcianej, jeśli wychodzi za mała
            velY = vel.y - acceleration * Time.fixedDeltaTime;
            velY = Mathf.Max(velY, desiredVel.y);
        }

        //ustalamy nową prędkość 
        rb.velocity = new Vector2(velX, velY);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RotateDisplayToMouse();
    }
    void FixedUpdate()
    {
        Move();
    }
}
