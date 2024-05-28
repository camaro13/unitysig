using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    public float time = 0.7f;
    public GameObject Obstacles;
    public GameObject Class1;
    public GameObject Class2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Falling", time, time);
    }


    void Falling()
    {
        Instantiate(Obstacles, new Vector3(Random.Range(0, 1900), 1300, 0), Quaternion.identity);
        Instantiate(Class1, new Vector3(Random.Range(0, 1900), 1300, 0), Quaternion.identity);
        Instantiate(Class2, new Vector3(Random.Range(0, 1900), 1300, 0), Quaternion.identity);
    }

    
}
