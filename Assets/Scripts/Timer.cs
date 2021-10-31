using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private float Chronometer;
    private int Second;
    private int Minute;

    private void Start()
    {
        Minute = 7;
        Second = 6;
    }

    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText(Minute + ":" + Second);

        Chronometer += Time.deltaTime;

        if(Chronometer >= 1f)
        {
            Second -= 1;
            Chronometer = 0;
        }

        if(Second <= 0)
        {
            Minute -= 1;
            Second = 59;
        }

        if(Minute <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
