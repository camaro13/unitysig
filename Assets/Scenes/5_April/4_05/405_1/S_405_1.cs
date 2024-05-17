using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
using System;

[System.Serializable]
public class s_405_1
{
    public string name;
    [TextArea]
    public string dialogue;
    public Sprite cg_M;
    public Sprite cg_F;
}
public class S_405_1 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] public TMP_Text txt_Name;
    [SerializeField] public TMP_Text txt_Dialogue;

    private string savePath;
    private int count = 0;
    private bool isman;
    private bool iswoman;
    private string gabage;
    private InfoMenu_S info;

    [SerializeField] private s_405_1[] dialogue;
    // Start is called before the first frame update
    void Start()
    {
        savePath = Application.persistentDataPath + "/save.txt";
        StreamReader sr = new StreamReader(savePath);
        gabage = sr.ReadLine();
        gabage = sr.ReadLine();
        isman = Convert.ToBoolean(sr.ReadLine());
        iswoman = Convert.ToBoolean(sr.ReadLine());
        count = 0;
        NextDialogue();
        
    }

    public void NextDialogue()
    {
        if (count < dialogue.Length)
        {
            if (dialogue[count].name == "me")
            {
                StreamReader sr = new StreamReader(savePath);
                txt_Name.text = sr.ReadLine();
            }
            else
            {
                txt_Name.text = dialogue[count].name;
            }
            txt_Dialogue.text = dialogue[count].dialogue;
            if (isman)
            {
                sprite_StandingCG.sprite = dialogue[count].cg_M;
            }
            else if (iswoman)
            {
                sprite_StandingCG.sprite = dialogue[count].cg_F;
            }
            count++;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
