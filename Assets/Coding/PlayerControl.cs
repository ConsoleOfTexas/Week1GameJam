using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Vector2 move;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused)
        {
            movePlayer();
        }
        //movePlayer();
    }

    public void movePlayer()
    {
        if (move.sqrMagnitude > 0.1f)
        {
            Vector3 movement = new Vector3(move.x, 0f, move.y);

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

}
