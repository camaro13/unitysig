using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_329_1_S_M : MonoBehaviour
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
        if (MainMenu_s.scenenumber == 31)
        {
            Destroy(this.gameObject);

        }
    }
}
