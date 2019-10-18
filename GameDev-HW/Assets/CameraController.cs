using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float right_limit = 28;
    public float left_limit = 0;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.x - player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current_position = transform.position;
        current_position.x = player.transform.position.x + offset;
        if (current_position.x <= right_limit && current_position.x >= left_limit)
            transform.position = current_position;
    }
}
