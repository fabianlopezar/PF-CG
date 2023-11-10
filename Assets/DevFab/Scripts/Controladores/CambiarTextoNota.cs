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
                _textoNota.text = "La primera posicion es D.";
                break;
            case 7:
                _textoNota.text = "";
                break;
            case 8:
                _textoNota.text = "";
                break;
            case 9:
                _textoNota.text = "";
                break;

            default:
                // Código para el caso en que el estado no coincida con ninguno de los casos anteriores
                Debug.Log("Estado desconocido");
                break;
        }
    }
}
