using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    public float movementSpeed;

    public static Vector3 startPos2;

    private void Start()
    {
        startPos2 = this.transform.position;
    }

    private void FixedUpdate()
    {
        if (HandlePlayerSelect.numPlayers != 1)
        {
            if (!Application.isMobilePlatform)
            {

                float v = Input.GetAxisRaw("VerticalD");
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
            }

            else
            {
                foreach (Touch touch in Input.touches)
                {
                    if (touch.phase != TouchPhase.Moved)
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * 0;
                    else
                    {
                        if (touch.position.x > Screen.width / 2)
                        {
                            float v = touch.deltaPosition.y / Player_1.divisor;
                            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
                        }
                    }
                }
            }
        }

       
    }

    public static void returnP2ToOriginalPosition()
    {
        GameObject.Find("Player 2").transform.position = startPos2;
    }
}
