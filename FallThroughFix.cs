using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FallThroughFix : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Player")
        {
            
             player.transform.position = new Vector3(player.transform.position.x, 2, player.transform.position.z);
            Debug.Log("I FELL THROUGH");

        }


    }
}
