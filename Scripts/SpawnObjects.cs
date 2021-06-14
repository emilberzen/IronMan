using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int delay = 1;
    public int frequency = 3;
    private GameObject fallenObject;
    List<GameObject> fallObjects = new List<GameObject>();


    void Start()
    {
        InvokeRepeating("spawnObject", delay, frequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnObject()
    {
        fallenObject = Instantiate(prefab, gameObject.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)), Quaternion.identity);



    }

}
