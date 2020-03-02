using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform Player;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float LookAngle = 70;
    public float LookDistance = 10;
    public float FireCooldown = 1;
    public float SearchCooldown = 10;
    
    public float WalkSpeed = 2;
    public float RotationSpeed = 10;
    
    public int nearestStartPoint = 0;
    int pointRightNow = 0;
    
    Vector3 startPos;
    Vector3 startRot;
    int startPoint;

    int LastSeenArea = 0;
    int nextPoint;

    float fireCooldown = 0;
    float searchCooldown = 0;

    int state = 100; //100 = idle, 101 = canattack

    Vector3 nextPointPos;
    Vector3 direction;
    float distance;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
        startPos = transform.position;
        startRot = transform.eulerAngles;
        startPoint = pointRightNow;
    }

    // Update is called once per frame
    void Update()
    {
        CooldownUpdate();
        if (CheckIfPlayerSeen())
        {
            return;
        }
        if (searchCooldown > 0)
        {
            Goto(LastSeenArea);
            return;
        }
        if (startPoint != pointRightNow)
        {
            Goto(startPoint, true);
        }
    }

    void Goto(int area, bool PointNotArea = false)
    {
        int pointTarget = AIpointsConnect.areaToPoint[area];
        if (PointNotArea)
        {
            pointTarget = area;
        }
        if (pointRightNow == pointTarget)
        {
            if (searchCooldown > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + RotationSpeed * Time.deltaTime);
                return;
            }
            else
            {
                transform.eulerAngles = startRot;
                transform.position = startPos;
                pointRightNow = startPoint;
                return;
            }
        }
        if (pointRightNow != -1)
        {
            nextPoint = AIpointsConnect.Road["" + pointRightNow + "," + pointTarget ];
            nextPointPos = AIpointsConnect.Points[nextPoint].position;
            direction = nextPointPos - transform.position;
            transform.up = direction.normalized;

            distance = Time.deltaTime * WalkSpeed;
            if (direction.magnitude <= distance)
            {
                transform.position = nextPointPos;
                pointRightNow = nextPoint;
            }
            else
            {
                transform.position += direction.normalized * distance;
                pointRightNow = -1;

            }
            return;
        }
        nextPointPos = AIpointsConnect.Points[nextPoint].position;
        direction = nextPointPos - transform.position;
        transform.up = direction.normalized;

        distance = Time.deltaTime * WalkSpeed;
        if (direction.magnitude <= distance)
        {
            transform.position = nextPointPos;
            pointRightNow = nextPoint;
        }
        else
        {
            transform.position += direction.normalized * distance;
            pointRightNow = -1;
        }

    }

    void CooldownUpdate()
    {
        fireCooldown -= Time.deltaTime;
        searchCooldown -= Time.deltaTime;
        if (fireCooldown < 0)
        {
            fireCooldown = 0;
        }
        if (searchCooldown < 0)
        {
            searchCooldown = 0;
        }
    }

    bool CheckIfPlayerSeen()
    {
        Vector3 Diffrence = transform.position - Player.position;
        if (Diffrence.magnitude > LookDistance)
        {
            return false;
        }
        Vector3 DiffrenceNorm = Diffrence.normalized;
        float angle = Vector3.Angle(DiffrenceNorm, transform.up);
        if (angle < 180 - LookAngle)
        {
            return false;
        }
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y) , - new Vector2(DiffrenceNorm.x, DiffrenceNorm.y), Diffrence.magnitude, LayerMask.GetMask("Default"), -2, 2);
        if (hit != null)
        {
            if (hit.collider.name == "Player")
            {
                angle = Vector3.Angle(Diffrence, Vector3.down);
                if (Player.position.x < transform.position.x)
                {
                    transform.eulerAngles = new Vector3(0, 0, angle);
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 360 - angle);
                }

                if (fireCooldown <= 0)
                {
                    fireCooldown = FireCooldown;
                    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                    rb.AddForce(firePoint.up * 20, ForceMode2D.Impulse);
                }
                searchCooldown = SearchCooldown;
                LastSeenArea = PlayerPosContainer.areaNumber;
                return true;
            }
        }
        return false;
    }

    public void InformEnemy()
    {
        searchCooldown = SearchCooldown;
        LastSeenArea = PlayerPosContainer.areaNumber;
    }
}
