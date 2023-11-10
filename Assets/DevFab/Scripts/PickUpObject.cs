/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebasti�n Rivas Jim�nez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
//https://youtu.be/8AHnorOx-7k
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpObject : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    /* <summary>
     descripci�n de atributo:Referencia al objeto que se puede recoger. Es el objeto que el jugador tiene la opci�n de recoger.
    </summary>*/
    public GameObject PickedObject;
    /* <summary>
     descripci�n de atributo:Guarda el objeto actualmente recogido por el jugador. Es null si no se ha recogido ning�n objeto.
    </summary>*/
    public Transform interationZone;
    /* <summary>
     descripci�n de atributo:La zona o punto en el que el objeto recogido se posicionar� una vez que ha sido recogido. Esencialmente, es el lugar donde el objeto se "adjunta" al jugador.
    </summary>*/
    private void Update()
    /* <summary>
descripci�n de metodo:Este m�todo se ejecuta en cada fotograma del juego. Verifica si hay un objeto que se puede recoger y
    si el jugador presiona la tecla 'F'. Si el jugador presiona 'F' y hay un objeto disponible para recoger (y el jugador no
    sostiene nada), el objeto se establece como "recogido": se desactiva su gravedad, se vuelve cinem�tico (no es afectado por
    la f�sica) y se mueve a la "zona de interacci�n". Si el jugador presiona 'F' mientras ya sostiene un objeto, este se suelta:
    se activa su gravedad, deja de ser cinem�tico y se elimina la referencia de que est� siendo sostenido.
</summary>*/
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObject>().isPickable==true&&PickedObject==null )
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<PickableObject>().isPickable = false;
                PickedObject.transform.SetParent(interationZone);
                PickedObject.transform.position = interationZone.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }else if (PickedObject !=null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
           
                PickedObject.GetComponent<PickableObject>().isPickable = true;
                PickedObject.transform.SetParent(null);
            
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject = null;
            }
        }
    }
}
