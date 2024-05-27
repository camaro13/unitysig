using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public MainMenu_s mainmenu_s;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenu_s.scenenumber == 3)
        {
            Destroy(this.gameObject);
            
        }
    }
}
