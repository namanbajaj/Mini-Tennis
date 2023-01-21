using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float movementSpeed;

    public static Vector3 startPos1;

    public static int divisor = 20;

    private void Start()
    {
        startPos1 = this.transform.position;        
    }

    private void FixedUpdate()
    {

        if(!Application.isMobilePlatform)
        {
            float v = Input.GetAxisRaw("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
        }

        else
        {
            foreach(Touch touch in Input.touches)
            {
                if(touch.phase != TouchPhase.Moved)
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * 0;
                else
                {
                    if (HandlePlayerSelect.numPlayers == 1 || (HandlePlayerSelect.numPlayers == 2 && touch.position.x < Screen.width / 2))
                    {
                        float v = touch.deltaPosition.y / divisor;
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;

                    }
                }
            }
        }
    }

    public static void returnP1ToOriginalPosition()
    {
        GameObject.Find("Player 1").transform.position = startPos1;
    }
}
