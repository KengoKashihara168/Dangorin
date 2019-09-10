using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    GameObject sceneController;

    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.Find("SceneController");
        Screen.SetResolution(600, 800, true, 60);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sceneController.GetComponent<SceneController>().ChangeScene("Game");
        }
    }

}
