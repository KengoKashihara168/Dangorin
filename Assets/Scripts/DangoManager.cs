using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoManager : MonoBehaviour
{
    [SerializeField] GameObject[] dangos;
    [SerializeField] GameObject kushi;
    [SerializeField] GameObject sceneController;
    int hitCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            kushi.GetComponent<Kushi>().moveFlag = true;
        }

        if(kushi.GetComponent<Kushi>().stopFlag)
        {
            for (int i = 0; i < dangos.Length; i++)
            {
                if (dangos[i].GetComponent<DangoController>().hitFlag) hitCount++;
            }

            if (hitCount >= 5)
            {
                sceneController.GetComponent<SceneController>().ChangeScene("Success");
            }
            else
            {
                sceneController.GetComponent<SceneController>().ChangeScene("misstake");
            }
        }
    }
}
