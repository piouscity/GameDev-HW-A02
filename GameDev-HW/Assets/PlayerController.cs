using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;
    Animator animator;
    Vector2 position;
    void Start()
    {
        animator = GetComponent<Animator>();
        position = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool leftPressed = Input.GetKey(KeyCode.A);
        if (rightPressed || leftPressed)
        {
            if (rightPressed)
            {
                position.x += speed;
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                position.x -= speed;
                GetComponent<SpriteRenderer>().flipX = true;
            }
            GetComponent<Transform>().position = position;
            animator.SetBool("moving", true);
        }
        else
            animator.SetBool("moving", false);
    }
}
