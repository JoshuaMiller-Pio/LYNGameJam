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

    void Start()
    {
        _playerRig = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerInput>();

        
            left = player.actions["Left"];
            right = player.actions["Right"];
     
     
    }


    void Update()
    {
        
    }


    public  void MoveLeft(InputAction.CallbackContext context)
    {

        Debug.Log("leftinital");
        if (context.performed)
        {

            StartCoroutine(IMoveLeft());
        }
        
    }
    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            StartCoroutine(IMoveRight());
        }
        
    }
   public void SpecialAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }

    IEnumerator IMoveLeft()
    {

        while (left.IsPressed())
        {
            Debug.Log("left");
            _playerRig.velocity = Vector2.left * Time.deltaTime * 100;
            yield return new WaitForSeconds(0.1f);
        }

        yield return null;
    }
    IEnumerator IMoveRight()
    {

        while (right.IsPressed())
        {
            _playerRig.velocity = Vector2.right * Time.deltaTime*100;
              yield return new WaitForSeconds(0.1f);
        }

        yield return null;
    }
}
