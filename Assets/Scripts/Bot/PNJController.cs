using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public float waitTime;
    public float waitTimeEnd;

    private int currentWaypointIndex;
    private bool isMoving = false;
    private bool isMovingForward = true;

    void Start()
    {
        currentWaypointIndex = 0;
        MoveToNextWaypoint();
    }

    void Update()
    {
        if (isMoving)
        {
            Vector2 targetPosition = waypoints[currentWaypointIndex].position;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            
            if (targetPosition.x < transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (new Vector2(transform.position.x, transform.position.y) == targetPosition)
            {
                if (currentWaypointIndex == waypoints.Length - 1 && isMovingForward)
                {
                    isMoving = false;
                    StartCoroutine(WaitAtWaypointEnd());
                }
                else if (currentWaypointIndex == 0 && !isMovingForward)
                {
                    isMoving = false;
                    StartCoroutine(WaitAtWaypointEnd());
                }
                else
                {
                    MoveToNextWaypoint();
                }
            }
        }
    }

    void MoveToNextWaypoint()
    {
        if (isMovingForward)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            currentWaypointIndex--;
            if (currentWaypointIndex < 0)
            {
                currentWaypointIndex = 1;
                isMovingForward = true;
            }
        }

        isMoving = true;
    }

    IEnumerator WaitAtWaypointEnd()
    {
        yield return new WaitForSeconds(isMovingForward ? waitTime : waitTimeEnd);
        isMovingForward = !isMovingForward;
        MoveToNextWaypoint();
    }
}