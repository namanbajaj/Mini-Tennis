using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Controller : MonoBehaviour
{
    public Ball_Movement ballMovement;
    public ScoreController scoreController;

    void Bounce(Collision2D c)
    {
        Debug.Log("Here");
        Vector3 bP = this.transform.position;
        Vector3 rP = c.gameObject.transform.position;

        float rH = c.collider.bounds.size.y;

        float x = c.gameObject.name == "Player 1" ? 1 : -1;

        float y = (bP.y - rP.y) / rH;
        Debug.Log($"{x} {y}");
        this.ballMovement.incrementHit();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
            this.Bounce(collision);
        else if (collision.gameObject.name == "WallLeft")
        {
            //Debug.Log("Wall left collision");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
            Player_1.returnP1ToOriginalPosition();
            Player_2.returnP2ToOriginalPosition();
        }
        else if (collision.gameObject.name == "WallRight")
        {
            //Debug.Log("Wall right collision");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));
            Player_1.returnP1ToOriginalPosition();
            Player_2.returnP2ToOriginalPosition();
        }
    }
}
