using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    private bool videoVisable;
    public GameObject video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoVisable = !videoVisable;

        }

        if (videoVisable)
        {
            video.SetActive(true);

        }
        else
        {

            video.SetActive(false);
        }
    }
}
