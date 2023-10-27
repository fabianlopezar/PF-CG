using UnityEngine;

public class ActivadorDeNotas : MonoBehaviour
{
    public GameObject _notaVisual;
    public bool activador;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& activador == true)
        {
            _notaVisual.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Escape)&& activador == true)
        {
            _notaVisual.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        IDObject idObject = other.GetComponent<IDObject>();
        if (idObject)
        {
            activador = true;
            CambiarTextoNota.Instance.CambiarTextoNotasUI(idObject.id);
        }
    /*    if (other.tag == "Player")
        {
            activador = true;
        }*/

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
