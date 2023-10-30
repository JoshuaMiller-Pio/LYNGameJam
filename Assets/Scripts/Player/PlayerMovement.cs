using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _playerRig;
    InputAction left,right;
    PlayerInput player;
    float move;
   public static Animator animator;
    SpriteRenderer spriteRenderer;
    public LayerMask groundLayer, groundLayer2; 
    public float raycastDistance = 0.1f;  
    private bool isGrounded;

  
       
        void Start()
    {
        _playerRig = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerInput>();
        animator = GetComponent<Animator>();
        
            left = player.actions["Left"];
            right = player.actions["Right"];
             spriteRenderer = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
            StartCoroutine(GroundCheck());
        move = Input.GetAxisRaw("Horizontal");
        Debug.Log(Input.GetAxisRaw("Horizontal"));

    }


    public void MoveLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            StartCoroutine(IMoveLeft());
        }
        else if(context.canceled)
        {
            _playerRig.velocity = new Vector2(0, _playerRig.velocity.y);

        }


    }
    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            StartCoroutine(IMoveRight());
        }
        else if (context.canceled)
        {
            _playerRig.velocity = new Vector2(0, _playerRig.velocity.y);

        }

    }
   public void SpecialAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, groundLayer);
            if (isGrounded)
            {
                _playerRig.velocity = new Vector2(_playerRig.velocity.x, 6f);
                
            }
        }
    }
    IEnumerator GroundCheck()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, groundLayer|groundLayer2);
        if (isGrounded)
        {
            isNOTFalling();
        }
        else
        {
            isFalling();
        }

        yield return null;
    }
  
    IEnumerator IMoveLeft()
    {

        while (left.IsPressed())
        {
            isMoving();

            spriteRenderer.flipX = true;

            _playerRig.velocity = new Vector2(move * 7f, _playerRig.velocity.y) ;
            yield return new WaitForSeconds(0.01f);
        }
        isNOTMoving();
        yield return null;
    }
    IEnumerator IMoveRight()
    {

        while (right.IsPressed())
        {
            isMoving();


            spriteRenderer.flipX = false;   
            _playerRig.velocity = new Vector2(move * 7f, _playerRig.velocity.y) ;
            yield return new WaitForSeconds(0.01f);
        }
        isNOTMoving();
        yield return null;
    }




    //change this to unity events
    public static void isMoving()
    {
        animator.SetBool("isWalking", true);
        
    }

    public static void isFalling()
    {
        animator.SetBool("isFalling", true);
    }
    public static  void isGrappling()
    {
        animator.SetBool("isGrappling", true);
    }

    public static void isNOTMoving()
    {
        animator.SetBool("isWalking", false);
    }

    public static void isNOTFalling()
    {
        animator.SetBool("isFalling", false);
    }
    public static void isNOTGrappling()
    {
        animator.SetBool("isGrappling", false);
    }
}
