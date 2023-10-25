using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMaletas : MonoBehaviour
{
    public static ControladorMaletas Instance { get; set; }

    public bool[] maletas;
    public bool maleta;

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
        ManejoReloj.Instance.TimerStart();
        maleta = false;
    }
    void Update()
    {
        
    }
    public void PuzleMaletasCompletado()
    {
        if (maletas[0]==true&& maletas[1] == true&&maletas[2] == true && maletas[3] == true && maletas[4] == true)
        {
            Debug.Log("Exito");
            ManejoReloj.Instance.Puzle1Terminado();
        }
        
    }
}
