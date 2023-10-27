using UnityEngine;
using TMPro;
public class Pesa : MonoBehaviour
{
    public TMP_Text _textoTMP;
    private void OnTriggerEnter(Collider other)
    {
        PickableObject pickableObject = other.GetComponentInParent<PickableObject>();
        if (pickableObject != null) {
            if (pickableObject.peso > 0)
            {
                _textoTMP.text = "" + other.GetComponentInParent<PickableObject>().peso + " kg";
            } 
        }
    }

}
