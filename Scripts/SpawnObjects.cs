using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int delay = 1;
    public int frequency = 3;
    private GameObject fallenObject;
    List<GameObject> fallObjects = new List<GameObject>();

    public TextMeshPro score; 

    void Start()
    {
        InvokeRepeating("spawnObject", delay, frequency);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            score.text = "0";
        }
    }

    public void spawnObject()
    {
        fallenObject = Instantiate(prefab, gameObject.transform.position + new Vector3(0, Random.Range(-1f, 1f), Random.Range(-1f, 1f)), Quaternion.identity);


        if(int.Parse(score.text) >= 2 && int.Parse(score.text) < 4)
        {

            fallenObject.GetComponent<Rigidbody>().mass = 0.1f;

        }else if(int.Parse(score.text) >= 4 && int.Parse(score.text) < 6) {

            fallenObject.GetComponent<Rigidbody>().mass = 0.2f;


        }
        else if(int.Parse(score.text) >= 6 && int.Parse(score.text) < 10)
        {

            fallenObject.GetComponent<Rigidbody>().mass = 0.7f;

        }
        else if (int.Parse(score.text) >= 10)
        {

            fallenObject.GetComponent<Rigidbody>().mass = 0.6f;

        }








    }

}
