using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class s_217_1
{
    public string name_M;
    [TextArea]
    public string dialogue_M;
    public Sprite cg_M;

    public string name_F;
    [TextArea]
    public string dialogue_F;
    public Sprite cg_F;
}
public class S_217_1 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] public TMP_Text txt_Name;
    [SerializeField] public TMP_Text txt_Dialogue;

    private string savePath;
    private int count = 0;
    private InfoMenu_S info;

    [SerializeField] private s_217_1[] dialogue;
    // Start is called before the first frame update
    void Start()
    {
        savePath = Application.persistentDataPath + "/save.txt";
        count = 0;
        NextDialogue();
        
    }

    public void NextDialogue()
    {
        if (info.toggle_gender_man == true)
        {
            if (count < dialogue.Length)
            {
                if (dialogue[count].name_M == "me")
                {
                    StreamReader sr = new StreamReader(savePath);
                    txt_Name.text = sr.ReadLine();
                }
                else
                {
                    txt_Name.text = dialogue[count].name_M;
                }
                txt_Dialogue.text = dialogue[count].dialogue_M;
                sprite_StandingCG.sprite = dialogue[count].cg_M;
                count++;
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
        else if (info.toggle_gender_woman == true)
        {
            if (count < dialogue.Length)
            {
                if (dialogue[count].name_F == "me")
                {
                    StreamReader sr = new StreamReader(savePath);
                    txt_Name.text = sr.ReadLine();
                }
                else
                {
                    txt_Name.text = dialogue[count].name_F;
                }
                txt_Dialogue.text = dialogue[count].dialogue_F;
                sprite_StandingCG.sprite = dialogue[count].cg_F;
                count++;
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
