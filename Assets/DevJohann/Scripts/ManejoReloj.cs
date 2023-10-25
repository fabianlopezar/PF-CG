using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ManejoReloj : MonoBehaviour
{
    public static ManejoReloj Instance { get; set; }
    public TMP_Text textMin;
    public TMP_Text textSeg;

    public TMP_Text textMilS;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    public float StartTime { get => startTime; set => startTime = value; }
    public float StopTime { get => stopTime; set => stopTime = value; }
    public float TimerTime { get => timerTime; set => timerTime = value; }
    public bool IsRunning { get => isRunning; set => isRunning = value; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        TimerReset();  
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        textMin.text = textSeg.text = textMilS.text = "00";
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;

        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
            Debug.Log(stopTime.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Math.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));
        if (isRunning)
        {
            textMin.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            textSeg.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            textMilS.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
        
    }
    public void Puzle1Terminado()
    {
        TimerStop();
        //
    }
    
}
