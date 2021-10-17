using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * Random.Range(3.0f, 5.0f) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score += 5;
        Destroy(gameObject);
    }

}
