using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpipes : MonoBehaviour
{
    public GameObject pipes;
    public float height;
    public float maxTime = 1f;
    float time = 0f;
       void Start()
    {
        GameObject newPipes = Instantiate(pipes);
        newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {
        if(time  > maxTime){
        GameObject newPipes = Instantiate(pipes);
        newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
        Destroy(newPipes,7f);
        time = 0;
        }

        time += Time.deltaTime;
    }
}
