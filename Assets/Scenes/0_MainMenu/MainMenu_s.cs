using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_s : MonoBehaviour
{
    // Start is called before the first frame update

    public Button Start_B, Exit_B;
    public static string beforedays;
    public static string nextdays;
    public static int nextscene;
    public static int scenenumber = 0;

    void Start()
    {
        //Start_B.onClick.AddListener(Start_B_P);
        //Exit_B.onClick.AddListener(Exit_B_P);
        beforedays = "";
        nextdays = "";
    }

    public void Start_B_P()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit_B_P()
    {
        Application.Quit();
    }
}
