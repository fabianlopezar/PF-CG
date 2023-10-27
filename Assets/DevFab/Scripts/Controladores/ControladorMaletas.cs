using UnityEngine;

public class ControladorMaletas : MonoBehaviour
{
    public static ControladorMaletas Instance { get; set; }

    public bool[] maletas;
    public bool maleta;

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
        maleta = false;
    }

    public void PuzleMaletasCompletado()
    {
        if (maletas[0]==true&& maletas[1] == true&&maletas[2] == true && maletas[3] == true && maletas[4] == true)
        {
            ManejoReloj.Instance.Puzle1Terminado();
            GameManager.Instance._timeLevel1 = ManejoReloj.Instance.TimeLevel();
            //Activar Animacion Puerta.
            animator.SetBool("Abrir", true);
        }
        
    }
}
