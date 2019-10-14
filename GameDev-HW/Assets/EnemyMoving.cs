using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;
    int count;
    int leng = 30;
    bool flip;
    Vector2 position;
    void Start()
    {
        position = GetComponent<Transform>().position;
        count = 0;
        flip = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < leng)
        {
            position.x += speed;
            GetComponent<Transform>().position = position;
            ++count;
        }
        else
        {
            speed = -speed;
            count = 0;
            flip = !flip;
            GetComponent<SpriteRenderer>().flipX = flip;
        }
    }
}
