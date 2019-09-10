using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kushi : MonoBehaviour
{
    private float speed;
    public bool moveFlag;
    public bool stopFlag;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        speed = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX;
        Vector2 mouse = Input.mousePosition;
        moveX = Camera.main.ScreenToWorldPoint(mouse).x;

        move.x = moveX;
        move.y = speed;
        transform.transform.position = move;

        if(moveFlag)
        {
            speed += 1.0f;
        }
        if(stopFlag)
        {
            speed = 0.0f;
        }

        if(transform.position.y == 0.0f)
        {
            stopFlag = true;
        }
    }

}
