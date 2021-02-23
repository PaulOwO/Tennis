using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public Text EndCounter;

    void Update()
    {
        //string timePlayingStr = timePlaying.ToString("You survived'mm':'ss'.'ff");
        // timeCounter.text = timePlayingStr;


        if (Input.GetKey(KeyCode.C))
        {
                SceneManager.LoadScene("AidenScene");
        }
    }
}
