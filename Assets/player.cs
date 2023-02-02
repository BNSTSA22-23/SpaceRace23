using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float movementForce = 10f;
    private float movementX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveWithKeyboardInput();
        AnimatePlayer();
    }
    void MoveWithKeyboardInput()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * movementForce;
    }
    private string RUN_ANIMATION = "is walking";
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>(); 
    }

    void AnimatePlayer()
    {
        if (movementX != 0)
        {
            if (movementX > 0)
            {
                sr.flipX = false;
            }
            else
            {
                sr.flipX = true;
            }
            anim.SetBool(RUN_ANIMATION, true);
        }
        else
        {
            anim.SetBool(RUN_ANIMATION, false);
        }
    }

    private SpriteRenderer sr;
}
