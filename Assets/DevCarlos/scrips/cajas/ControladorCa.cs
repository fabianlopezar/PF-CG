using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCa : MonoBehaviour
{
    
    public int cajasPuestas;
    public GameObject puerta;


    private void Update()
    {
        if (cajasPuestas == 8)
        {
            puerta.SetActive(true);

        }
    }













    public  void sumarCajas(int cajas)
    {
        
        cajasPuestas += cajas;
    }

    
}
