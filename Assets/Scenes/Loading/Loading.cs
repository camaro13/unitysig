using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public TMP_Text beforeDay;
    public TMP_Text nextDay;

    private float waittime = 3f;
    private float timer = 0;

    [SerializeField] public string BeforeDay;
    [SerializeField] public string NextDay;
    void Start()
    {
        beforeDay.text = BeforeDay;
        nextDay.text = NextDay;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.5f, 0, 0);

        timer += Time.deltaTime;

        if (timer > waittime)
        {
            SceneManager.LoadScene(0);
        }
    }
}
