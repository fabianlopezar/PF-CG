using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

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

    int minutesInt;
    int secondsInt ;
    int seconds100Int ;

    public float StartTime;
    public float StopTime;
    public float TimerTime;
    public bool IsRunning;

    private void Start()
    {
        EncontrarVariables();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
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
            isRunning = false;
            stopTime = timerTime;
        }
        //Debug.Log("Tiempo Final fue de: " + minutesInt +":"+ secondsInt+":" + seconds100Int);
    }

    void Update()
    {
        Cronometro();
    }

    private void Cronometro()
    {
        timerTime = stopTime + (Time.time - startTime);
        minutesInt = (int)timerTime / 60;
        secondsInt = (int)timerTime % 60;
        seconds100Int = (int)(Math.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));
        if (isRunning)
        {
            textMin.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            textSeg.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            textMilS.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
         //   Debug.Log(minutesInt + "-" + seconds100Int + "-" + seconds100Int);
        }
    }

    public void Puzle1Terminado()
    {
        TimerStop();
     
    }
    public string TimeLevel()//atrapo el tiempo jugado y lo devuelvo.
    {
        string timeLevelcath = minutesInt + ":" + secondsInt + ":" + seconds100Int;
        return timeLevelcath;
    }
    public void EncontrarVariables()
    {
        GameObject text1 = GameObject.Find("TextMin");
        GameObject text2 = GameObject.Find("TextSeg");
        GameObject text3 = GameObject.Find("TextMilS");

        if (text1 != null)
        {
            textMin = text1.GetComponent<TMP_Text>();
        }
        if (text2 != null)
        {
            textSeg = text2.GetComponent<TMP_Text>();
        }
        if (text3 != null)
        {
            textMilS = text3.GetComponent<TMP_Text>();
        }

        else
        {
            Debug.Log("Manejo reloj: Deberia existir un TMP en pantalla.");
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Este método se ejecutará después de cargar la escena
        //Debug.Log("Escena cargada: " + scene.name);
        EncontrarVariables();
        TimerReset();
        // Aquí puedes poner el código que deseas ejecutar después de cambiar de escena
    }
}
