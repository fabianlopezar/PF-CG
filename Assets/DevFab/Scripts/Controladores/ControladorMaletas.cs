using UnityEngine;

public class ControladorMaletas : MonoBehaviour
{
    public static ControladorMaletas Instance { get; set; }

    public bool[] maletas;
    public bool maleta;
    public int nivelActual;
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
     //   DontDestroyOnLoad(this.gameObject);
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
        bool todosCompletados = true;
        for (int i = 0; i < maletas.Length; i++)
        {
            if (!maletas[i])
            {
                todosCompletados = false;
                break;
            }
        }
        if (todosCompletados)//Si todos son verdaderos
        {
            ManejoReloj.Instance.Puzle1Terminado(); //Detener el cronometro.
            GameManager.Instance.TiempoNivelSuperado(nivelActual);//guardar el tiempo jugado.
            animator.SetBool("Abrir", true); //Activar Animacion Puerta.
        }
        
    }
}
