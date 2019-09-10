using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resultcontroller : MonoBehaviour
{
    GameObject sceneController;
    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.Find("SceneController");
        //Debug.Log(DangoManager.hitCount);
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if (time >= 350)
        {
            sceneController.GetComponent<SceneController>().ChangeScene("Title");
        }
    }
}
