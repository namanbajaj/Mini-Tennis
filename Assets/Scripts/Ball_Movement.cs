using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float movementSpeed;
    public float speedIncrement;
    public float maxSpeed;

    int hitCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());       
    }

    void PositionBall(bool isPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }

        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }

     public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);

        this.hitCount = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else
            this.MoveBall(new Vector2(1, 0));

    }

    public void MoveBall(Vector2 dir)
    {
        Vector2 ndir = dir.normalized;
        float speed = this.movementSpeed + this.speedIncrement * this.hitCount;
        if (speed > maxSpeed)
            speed = maxSpeed;

        Debug.Log($"Ball speed is now {speed}");

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = ndir * speed;
    }

    public void incrementHit()
    {
        this.hitCount++;
    }

}
