using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMake : MonoBehaviour
{

    public GameObject star;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Random.Range(2.5f, 5.0f) * Time.deltaTime;
        if(timer > 20)
        {
            timer = 0;
            GameObject newStar = Instantiate(star);
            newStar.transform.position = new Vector3(Random.Range(2.0f, 10.0f), Random.Range(-3.0f, 4.0f), 0);
            Destroy(newStar, 15.0f);
        }
    }
}
