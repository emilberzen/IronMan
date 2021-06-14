using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collisiondetect : MonoBehaviour
{

    public int counter;
    public TextMeshProUGUI test;

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "fallObject")
        {
            Destroy(collision.gameObject,0);
            Debug.Log("HEYY MR!!!!!!!!");
            counter++;
            test.text = counter.ToString(); ;
                
        }
    }

}
