using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xAxis;
    private Rigidbody2D rb2d;
    private bool isCrouchPressed;

    [SerializeField]
    private float walkSpeed = 5f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        //Checking for inputs
        xAxis = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            isCrouchPressed = true;
        }

    }
    private void FixedUpdate()
    {

        //------------------------------------------

        //Check update movement based on input
        Vector2 vel = new Vector2(0, rb2d.velocity.y);

        if (xAxis < 0)
        {
            vel.x = -walkSpeed;
            transform.localScale = new Vector2(-1, 1);
        }
        else if (xAxis > 0)
        {
            vel.x = walkSpeed;
            transform.localScale = new Vector2(1, 1);

        }
        else
        {
            vel.x = 0;

        }
        //assign the new velocity to the rigidbody
        rb2d.velocity = vel;


       

    }

}
