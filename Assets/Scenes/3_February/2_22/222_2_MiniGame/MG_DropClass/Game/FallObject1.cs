using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FallObject1 : MonoBehaviour
{
    ChaPlayer Cplayer;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
