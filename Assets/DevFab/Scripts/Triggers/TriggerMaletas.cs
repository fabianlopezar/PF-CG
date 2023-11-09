using UnityEngine;

public class TriggerMaletas : MonoBehaviour
{
    public float valorRequisito;
    public int posicion;
 
    private void OnTriggerEnter(Collider other)
    {
        PickableObject pickableObject = other.GetComponentInParent<PickableObject>();
        if ( pickableObject!=null)
        {         
            if(other.GetComponentInParent<PickableObject>().peso == valorRequisito)    
            ControladorMaletas.Instance.maletas[posicion]=true; // El cubo esta en la posicion Correcta.
            ControladorMaletas.Instance.PuzleMaletasCompletado(); // El cubo esta en la posicion Correcta.
        }
    }
}
