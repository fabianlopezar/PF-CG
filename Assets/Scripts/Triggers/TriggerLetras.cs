using UnityEngine;

public class TriggerLetras : MonoBehaviour
{
    public int letraRequerida;
    public int posicionLetra;

    private void OnTriggerEnter(Collider other)
    {
        IDObject idObject = other.GetComponent<IDObject>();
        if (idObject != null)
        {
            if(other.GetComponent<IDObject>().id== letraRequerida)
            {
                ControladorMaletas.Instance.maletas[posicionLetra] = true;
                ControladorMaletas.Instance.PuzleMaletasCompletado();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ControladorMaletas.Instance.maletas[posicionLetra] = false;
    }
}
