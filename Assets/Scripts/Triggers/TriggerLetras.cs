using UnityEngine;

public class TriggerLetras : MonoBehaviour
{
    public int letraRequerida;
    public int posicionLetra;
    public GameObject objCambiarColor;
    private void OnTriggerStay(Collider other)
    {

        IDObject idObject = other.GetComponent<IDObject>();
        if (idObject != null)
        {
            if (other.GetComponent<IDObject>().id == letraRequerida)
            {
                ControladorMaletas.Instance.maletas[posicionLetra] = true;
                ControladorMaletas.Instance.PuzleMaletasCompletado();
                Renderer renderer = objCambiarColor.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material.color = Color.green;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ControladorMaletas.Instance.maletas[posicionLetra] = false;
        
    }
}
