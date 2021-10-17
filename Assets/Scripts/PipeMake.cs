using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMake : MonoBehaviour
{

    public GameObject pipe;
    float timer = 0;
    public float timeDiff;

    // Start is called before the first frame update
    void Start()
    {
        GameObject startPipe = Instantiate(pipe);
        startPipe.transform.position = new Vector3(5, Random.Range(-3.2f, 4.2f), 0);
        //y축 4.2 ~ -3.2
        Destroy(startPipe, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff)
        {
            timer = 0;
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(5, Random.Range(-3.2f, 4.2f), 0);
            Destroy(newPipe, 10.0f);
        }
    }
}
