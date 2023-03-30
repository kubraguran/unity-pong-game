using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < 5)

        {
            rigidbody2D.velocity = new Vector2(0, 1) * speed;

        }
        else if(Input.GetKey(downKey) && transform.position.y > -5)
        {
            rigidbody2D.velocity = new Vector2(0, -1) * speed;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
