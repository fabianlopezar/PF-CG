using UnityEngine;

public class TriggerCajas : MonoBehaviour
{
    public float valorRequisito;
    public int posicion;

    private void OnTriggerEnter(Collider other)
    {
        PickableObject pickableObject = other.GetComponentInParent<PickableObject>();
        if (pickableObject != null)
        {
            if (other.GetComponentInParent<PickableObject>().peso == valorRequisito)
            ControladorCajas.Instance.cajas[posicion] = true; // El cubo esta en la posicion Correcta.
            ControladorCajas.Instance.PuzleMaletasCompletado(); // El cubo esta en la posicion Correcta.
        }
    }
}
