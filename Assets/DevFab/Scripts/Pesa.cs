using UnityEngine;
using TMPro;
public class Pesa : MonoBehaviour
{
    public TMP_Text _textoTMP;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<PickableObject>().peso>0)
        {
            Debug.Log("d");
            _textoTMP.text =""+ other.GetComponentInParent<PickableObject>().peso+" kg";
           
        }
    }

}
