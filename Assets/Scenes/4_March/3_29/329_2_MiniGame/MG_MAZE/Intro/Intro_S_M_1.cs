using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_S_M_1 : MonoBehaviour
{
    public MainMenu_s mainMenu_S;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenu_s.scenenumber == 33 || MainMenu_s.scenenumber == 34)
        {
            Destroy(this.gameObject);

        }
    }
}
