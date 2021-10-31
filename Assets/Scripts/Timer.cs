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
    private int cooldownTimer;
    private int cooldown;

    private void Start()
    {
        Minute = 6;
        Second = 66;
        cooldown = 0;
        cooldownTimer = (Minute * 60) + Second - Minute;
    }

    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText(Minute + ":" + Second);

        Chronometer += Time.deltaTime;

        if(Chronometer >= 1f)
        {
            cooldown += 1;
            Second -= 1;
            Chronometer = 0;
        }

        if(Second <= 0)
        {
            Minute -= 1;
            Second = 66;
        }

        if(cooldown >= cooldownTimer)
        {
            SceneManager.LoadScene(2);
        }
    }
}
