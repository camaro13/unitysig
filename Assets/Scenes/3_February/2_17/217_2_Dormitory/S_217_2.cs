using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class S_217_2 : MonoBehaviour
{
    public Button Next_B;

    private void Start()
    {
        
    }

    public void Next_B_P()
    {
        SceneManager.LoadScene(4);
    }    
}
