using UnityEngine;
using TMPro;
public class CambiarTextoNota : MonoBehaviour
{
    public static CambiarTextoNota Instance { get; set; }

    public TMP_Text _textoNota;
    private void Awake()
    {
        Instanciar();
    }
    private void Start()
    {
        string name = "TMP-Nota";
        GameObject objEncontrado = GameObject.Find(name);
        if (objEncontrado != null)
        {
            _textoNota = objEncontrado.GetComponent<TMP_Text>();
        }
        else
        {
            Debug.Log("CambiarTextoNotas: Deberia existir un TMP en pantalla.");
        }
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
    public void CambiarTextoNotasUI(int numeroNota)
    {
        switch (numeroNota)
        {
            case 1:
                _textoNota.text = "En los aeropuertos la entrada de maletas funcionan como una estructura de datos Cola.";
                break;
            case 2:
                _textoNota.text = "El primero que entra es el primero en salir (FIFO).";
                break;
            case 3:
                _textoNota.text = "Para saber el peso de la maleta existe una gramera.";
                break;
            case 4:
                _textoNota.text = "En ocaciones las colas se ordenan de menor a mayor.";
                break;
            case 5:
                _textoNota.text = "La Cola tiene varios métodos: encolar, desencolar y estaVacia.";
                break;
            case 6:
                _textoNota.text = "Mueve los cubos para poder ordenar el arbol.";
                break;
            case 7:
                _textoNota.text = "La primera posicion es la D.";
                break;
            case 8:
                _textoNota.text = "La segunda posicion es la A.";
                break;
            case 9:
                _textoNota.text = "La tercera posicion es la I.";
                break;

            default:
                // Código para el caso en que el estado no coincida con ninguno de los casos anteriores
                Debug.Log("Estado desconocido");
                break;
        }
    }
}
