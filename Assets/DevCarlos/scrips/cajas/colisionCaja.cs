using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCaja : MonoBehaviour
    
{
    public ControladorCa controladorCa;
    public int NumeroCaja=1;
    public int valor=1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == NumeroCaja.ToString())
        {
            controladorCa.cajasPuestas = controladorCa.cajasPuestas + 1;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == NumeroCaja.ToString())
        {
            controladorCa.cajasPuestas = controladorCa.cajasPuestas -1;

        }
    }
}
