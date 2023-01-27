using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xAxis;
    private Rigidbody2D rb2d;
    private Animator animator;
    public bool isCrouchPressed;
    private bool isRunning;
    private string currentAnimaton;

    [SerializeField]
    private float walkSpeed = 5f;

    //States

    const string PLAYER_IDLE = "HaruIdle";
    const string PLAYER_RUN = "HaruRun";
    const string PLAYER_WALK = "HaruWalk";
    const string PLAYER_CROUCH = "HaruCrouch";

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
       

        if (Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log("crouch");
            isCrouchPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouchPressed = false;
        }
        //Checking for inputs
        xAxis = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {

        //------------------------------------------

        //Check update movement based on input
        Vector2 vel = new Vector2(0, rb2d.velocity.y);
      

        if (xAxis < 0 &&!isCrouchPressed)
        {
            vel.x = -walkSpeed;
            transform.localScale = new Vector2(-1, 1);

        }
        else if (xAxis > 0 &&!isCrouchPressed)
        {
            vel.x = walkSpeed;
            transform.localScale = new Vector2(1, 1);

        }
        else if(xAxis == 0 && !isCrouchPressed)
        {
            vel.x = 0;
            ChangeAnimationState(PLAYER_IDLE);
        }
        else
        {
            vel.x = 0;
            ChangeAnimationState(PLAYER_CROUCH);
        }

        if(xAxis != 0 & !isRunning)
        {
            ChangeAnimationState(PLAYER_WALK);

        }
        else if(xAxis != 0 & isRunning)
        {
            ChangeAnimationState(PLAYER_RUN);

        }
        //assign the new velocity to the rigidbody
        rb2d.velocity = vel;


       

    }
    void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimaton == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimaton = newAnimation;
    }
}
