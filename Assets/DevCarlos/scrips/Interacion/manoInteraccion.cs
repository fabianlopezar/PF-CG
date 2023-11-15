using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manoInteraccion : MonoBehaviour
{
    public GameObject cubo;
    public Transform mano;

    private bool activo;

    // Update is called once per frame
    void Update()
    {
        if (activo == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cubo.transform.SetParent(mano);
                cubo.transform.position = mano.position;
                cubo.GetComponent<Rigidbody>().isKinematic = true;

            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cubo.transform.SetParent(null);
            cubo.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activo = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activo = false;
        }
    }
}
