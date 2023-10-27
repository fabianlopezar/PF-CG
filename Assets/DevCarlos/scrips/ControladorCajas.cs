using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCajas : MonoBehaviour
{
    public static ControladorCajas Instance { get; set; }

    public bool[] cajas;
    public bool caja;

    public Animator animator;

    private void Awake()
    {
        Instanciar();
    }

    private void Instanciar()
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
        IniciarCronometro();

    }

    private void IniciarCronometro()
    {
        ManejoReloj.Instance.TimerStart();
        caja = false;
    }

    public void PuzleMaletasCompletado()
    {
        if (cajas[0] == true && cajas[1] == true && cajas[2] == true && cajas[3] == true && cajas[4] == true)
        {
            ManejoReloj.Instance.Puzle1Terminado();
            GameManager.Instance._timeLevel1 = ManejoReloj.Instance.TimeLevel();
            //Activar Animacion Puerta.
            animator.SetBool("Abrir", true);
        }

    }
}
