using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail_s1 : MonoBehaviour
{
    public MainMenu_s MainMenu_s;
    // Start is called before the first frame update
    void Start()
    {
        MainMenu_s.scenenumber++;
        MainMenu_s.beforedays = "2월 19일";
        MainMenu_s.nextdays = "2월 22일";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next_S()
    {
        SceneManager.LoadScene(MainMenu_s.scenenumber);
    }

}
