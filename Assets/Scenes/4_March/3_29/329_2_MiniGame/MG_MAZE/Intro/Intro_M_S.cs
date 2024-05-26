using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro_M_S : MonoBehaviour
{
    public MainMenu_s MainMenu_s;
    // Start is called before the first frame update
    void Start()
    {
        MainMenu_s.scenenumber++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextS()
    {
        SceneManager.LoadScene(MainMenu_s.scenenumber);
    }
}
