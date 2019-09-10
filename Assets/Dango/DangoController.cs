using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _directionFlag;
    private Rigidbody2D _rigid;
    private float _stratPosX;
    public bool hitFlag;
    
    bool _stopFlag;
    // Use this for initialization
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _stratPosX = _rigid.position.x;
        if (_directionFlag == true)
        {
            _speed *= -1.0f;
        }
        hitFlag = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (_stopFlag)
        {
            _speed = 0f;
        }

        Vector2 _vec=new Vector2(_speed,0);
        _rigid.velocity = _vec;
    }
    void OnBecameInvisible()
    {
        _rigid.position = new Vector2(_stratPosX, _rigid.position.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.tag.Equals("Kushi")) return;
        hitFlag = true;
        _stopFlag = true;
    }
}
