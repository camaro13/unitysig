using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notice_S : MonoBehaviour
{
    public MainMenu_s MainMenu_s;
    public SoundManager SoundManager;
    // Start is called before the first frame update
    void Start()
    {
        MainMenu_s.scenenumber++;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Next()
    {
        SceneManager.LoadScene(MainMenu_s.scenenumber);
    }
}
