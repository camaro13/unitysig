using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton_s : MonoBehaviour
{
    // Start is called before the first frame update

    public Button Start_B, Exit_B;

    void Start()
    {
        //Start_B.onClick.AddListener(Start_B_P);
        //Exit_B.onClick.AddListener(Exit_B_P);
    }

    public void Start_B_P()
    {
        SceneManager.LoadScene(6);
    }
    public void Exit_B_P()
    {
        Application.Quit();
    }
}
