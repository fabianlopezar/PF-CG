using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Trigger : MonoBehaviour
{//codigo original fabian lopez
   public int color;  
   public  ManagerT a;
   public ParticleSystem particulasAura;
   public GameObject particles;
    public GameObject textPopUp;

    private void Start()
    {
        a = FindObjectOfType<ManagerT>();
 
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("rojo")&& color==0)
        {
            a.rojoT = true;              
         //           particulasAura.Play();
                          
        }
        if (other.gameObject.CompareTag("verde")&&color == 1)
        {
           a.verdeT = true;
        }
        if (other.gameObject.CompareTag("azul")&& color== 2)
        {
            a.azulT = true;
        }
        if (other.gameObject.CompareTag("amarillo") && color == 3)
        {
            a.amarilloT = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rojo") && color == 0)
        {
            //      particulasAura.Play();
            instanciarparticles();
        }
        if (other.gameObject.CompareTag("verde") && color == 1)
        {
            instanciarparticles();
        }
        if (other.gameObject.CompareTag("azul") && color == 2)
        {
            instanciarparticles();
        }
        if (other.gameObject.CompareTag("amarillo") && color == 3)
        {
            instanciarparticles();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("rojo") )
        {
          a.  rojoT = false;
        }
        if (other.gameObject.CompareTag("verde") )
        {
           a. verdeT = false;
        }
        if (other.gameObject.CompareTag("azul") )
        {
          a.  azulT = false;
        }
        if (other.gameObject.CompareTag("amarillo"))
        {
            a.amarilloT = false;
        }
    }
   
    public void instanciarparticles()
    {
        Instantiate(particles, transform.position, transform.rotation);
        //    Instantiate(textPopUp, new Vector3(-1.045118f,1.026f,0.175f), Quaternion.identity);
        Instantiate(textPopUp, transform.position, transform.rotation);
    }
}
