using UnityEngine;

public class ActivadorDeNotas : MonoBehaviour
{
    public GameObject _notaVisual;
    public bool activador;
    private void Update()
    {
     _notaVisual.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        IDObject idObject = other.GetComponent<IDObject>();
        if (idObject)
        {
            activador = true;
            CambiarTextoNota.Instance.CambiarTextoNotasUI(idObject.id);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activador = false;
            _notaVisual.SetActive(false);
        }
    }

}
