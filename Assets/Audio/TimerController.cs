using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timeCounter;  //serialze

    public TimeSpan timePlaying;
    public bool timerGoing;
    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
       timeCounter.text = "00:00.00";
       timerGoing = false;
       TimerController.instance.BeginTimer();

    }

    public void BeginTimer()
    {
        elapsedTime = 0f;
        timerGoing = true;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
            yield return null;
        }
    } 
}
