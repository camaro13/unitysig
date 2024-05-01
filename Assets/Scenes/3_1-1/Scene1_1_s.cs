using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class scene1_1_s
{
    public string name;
    [TextArea]
    public string dialogue;
    public Sprite cg;
}
public class Scene1_1_s : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] public TMP_Text txt_Name;
    [SerializeField] public TMP_Text txt_Dialogue;

    private string savePath;
    private int count = 0;

    [SerializeField] private scene1_1_s[] dialogue;
    // Start is called before the first frame update
    void Start()
    {
        savePath = Application.persistentDataPath + "/save.txt";
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
            sprite_StandingCG.sprite = dialogue[count].cg;
            count++;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
