using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class S_217_2 : MonoBehaviour
{
    public Button Next_B;

    public MainMenu_s MainMenu_s;

    private void Start()
    {
        MainMenu_s.scenenumber++;
    }

    public void Next_B_P()
    {
        SceneManager.LoadScene(MainMenu_s.scenenumber);
    }    
}
