using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("IsHitting") == true)
        {
            horizontalMove = 0f;
        }

        if (animator.GetBool("IsHitting") == false)
        {


            // Animations

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            //get Input from the character
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                animator.SetBool("Is Jumping", true);
                jump = true;
            }

            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
    }

    public void OnLanding()
    {
        animator.SetBool("Is Jumping", false);
    }

    private void FixedUpdate()
    {
        //Move the character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }

}
