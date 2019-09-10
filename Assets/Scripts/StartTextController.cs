using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartTextController : MonoBehaviour
{
    [SerializeField] Image start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float alpha = Mathf.Sin(Time.time);
        alpha = Mathf.Abs(alpha);
        Color color = start.color;
        
        color.a = alpha;
        start.color = color;


    }
}
