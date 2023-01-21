using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float movementSpeed;
    public GameObject ball;

    private void FixedUpdate()
    {
        if(HandlePlayerSelect.numPlayers == 1)
        {
            float dif = this.transform.position.y - ball.transform.position.y;
            if (Mathf.Abs(dif) > 50)
            {
                if (dif < 0)
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
                else
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;
            }
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * movementSpeed;
        }
    }
}
