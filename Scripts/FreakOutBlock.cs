using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FreakOutBlock : MonoBehaviour
{
    public GameObject leftFoot;
    public GameObject head;

    public float threshold = 2;

    public GameObject ironMan;

    private bool isTracking = true;

    public GameObject rigi;


    private void Update()
    {
        

        if (leftFoot.transform.position.y > 0.4f && !isTracking)
        {

            Debug.Log("I'm fucked up " + leftFoot.transform.position.y);
            ironMan.SetActive(false);
            isTracking = true;
        }
        else if(leftFoot.transform.position.y < 0.4f && isTracking)
        {
            ironMan.SetActive(true);
            Debug.Log("MEAANTIME SAFE HERE" + leftFoot.transform.position.y);
            isTracking = false;
        }
        
    }


}
