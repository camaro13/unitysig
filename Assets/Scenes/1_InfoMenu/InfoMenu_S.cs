using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Analytics;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoMenu_S : MonoBehaviour
{

    [SerializeField] public TMP_InputField input_name;
    [SerializeField] public TMP_InputField input_major;
    [SerializeField] public Toggle toggle_gender_man;
    [SerializeField] public Toggle toggle_gender_woman;

    public MainMenu_s MainMenu_s;

    private string savePath;
    public static int C_score = 50;
    public static bool toggle_gender_man_B;
    public static bool toggle_gender_woman_B;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu_s.scenenumber++;

        savePath = Application.persistentDataPath + "/save.txt";
        toggle_gender_man.onValueChanged.AddListener(toggle_man);
        toggle_gender_woman.onValueChanged.AddListener(toggle_woman);
    }

    public void SaveData()
    {
        StreamWriter writer = new StreamWriter(savePath);
        writer.WriteLine(input_name.text);
        writer.WriteLine(input_major.text);
        writer.WriteLine(toggle_gender_man_B);
        writer.WriteLine(toggle_gender_woman_B);
        writer.Close();
        SceneManager.LoadScene(2);
        Debug.Log("Data Saved to : " + savePath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle_man(bool _bool)
    {
        toggle_gender_man_B = _bool;
    }

    public void toggle_woman(bool _bool)
    {
        toggle_gender_woman_B = _bool;
    }

    public void Back_B_P()
    {
        SceneManager.LoadScene(MainMenu_s.scenenumber);
    }

}
