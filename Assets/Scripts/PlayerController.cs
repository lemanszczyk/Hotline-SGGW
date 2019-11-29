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
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Vector2 direction = hit.point - position;
            float newAngle = Vector3.Angle(direction, Vector3.up);
            if (hit.point.x > transform.position.x)
            {
                newAngle = 360 - newAngle;
            }
            playerDisplay.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newAngle);
        }
    }

    void Move()
    {
        Vector2 vel = rb.velocity;
        Vector2 desiredVel = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        desiredVel *= maxspeed;
        float velX, velY;
        if (desiredVel.x >= vel.x)
        {
            velX = vel.x + acceleration * Time.fixedDeltaTime;
            velX = Mathf.Min(velX, desiredVel.x);
        }
        else
        {
            velX = vel.x - acceleration * Time.fixedDeltaTime;
            velX = Mathf.Max(velX, desiredVel.x);
        }
        if (desiredVel.y >= vel.y)
        {
            velY = vel.y + acceleration * Time.fixedDeltaTime;
            velY = Mathf.Min(velY, desiredVel.y);
        }
        else
        {
            velY = vel.y - acceleration * Time.fixedDeltaTime;
            velY = Mathf.Max(velY, desiredVel.y);
        }
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
