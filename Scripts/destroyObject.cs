using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
	// Start is called before the first frame update

	private void Awake()
	{

	}
	void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "road")
        {
            Destroy(gameObject,1);
        } 


    }

}
