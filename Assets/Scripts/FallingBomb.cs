using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBomb : MonoBehaviour
{
    void Start()
    {
        float randomX = Random.Range(10f, 100f);
        float randomY = Random.Range(10f, 100f);
        float randomZ = Random.Range(10f, 100f);

        Rigidbody bomb = GetComponent<Rigidbody>();
        bomb.AddTorque(randomX, randomY, randomZ);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
