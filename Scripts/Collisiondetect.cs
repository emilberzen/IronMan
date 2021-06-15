using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collisiondetect : MonoBehaviour
{

    public int counter;
    public TextMeshPro counterDisp;
    public MeshDestroy meshDestroy;
    void OnCollisionEnter(Collision collision)
    {

        
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "fallObject")
        {

            int currentVal = int.Parse(counterDisp.text) + 1;
            Debug.Log("HEYY MR!!!!!!!!");
            counter++;
            counterDisp.text = currentVal.ToString();
            collision.gameObject.GetComponent<MeshDestroy>().DestroyMesh();
            
        }

    
    }

}
