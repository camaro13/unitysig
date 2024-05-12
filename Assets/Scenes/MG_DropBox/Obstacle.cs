using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float time = 1.0f;
    public GameObject Obstacles;
    public GameObject Boxes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Falling", time, time);
    }


    void Falling()
    {
        Instantiate(Obstacles, new Vector3(Random.Range(0, 1900), 1100, 0), Quaternion.identity);
        Instantiate(Boxes, new Vector3(Random.Range(0, 1900), 1100, 0), Quaternion.identity);
    }

    
}
