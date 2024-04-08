using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class Scene1_1_S : MonoBehaviour
{

    
    [SerializeField] public TMP_Text S_name;
    [SerializeField] public TMP_Text S_Contents;
    List<Dictionary<string, object>> data_Dialog;

    [SerializeField] public SpriteRenderer pic0;
    [SerializeField] public Sprite pic1;
    [SerializeField] public Sprite pic2;
    int i = 0;
    string garbage;
    // Start is called before the first frame update
    void Start()
    {
        data_Dialog = CSVReader.Read("Dilog");
        
    }

    public void Show_Text()
    {
        StreamReader reader = new StreamReader(Application.persistentDataPath + "/save.txt");
        
        if ((string)data_Dialog[i]["Name"] == "none")
        {
            S_name.text = reader.ReadLine();
            pic0.sprite = pic1;
        }
        else if ((string)data_Dialog[i]["Name"] != "none")
        {
            S_name.text = (string)data_Dialog[i]["Name"];
            pic0.sprite = pic2;
        }
        S_Contents.text = data_Dialog[i]["Content"].ToString();
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
