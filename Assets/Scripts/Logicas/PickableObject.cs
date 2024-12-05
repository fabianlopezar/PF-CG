/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebasti�n Rivas Jim�nez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;
    /* <summary>
     descripci�n de atributo: Determina si el objeto puede ser recogido o no. Es verdadero (true) si el objeto est� disponible para ser recogido.
    </summary>*/
    public float peso;
    /* <summary>
     descripci�n de atributo: Representa el peso del objeto. Este atributo podr�a usarse para limitar qu� objetos puede recoger el jugador en funci�n
    de su capacidad o para afectar la f�sica del objeto.
    </summary>*/

    private void OnTriggerEnter(Collider other)
    /* <summary>
descripci�n de metodo:Este m�todo se activa cuando otro objeto con un Collider entra en el �rea del Collider de este objeto
    (que se supone es un Trigger). Si el objeto entrante tiene la etiqueta "Mano", se actualiza la referencia del objeto 
    que puede ser recogido
    (ObjectToPickUp) en el script PickUpObject del padre del Collider, se�alando a este objeto como recogible.
</summary>*/
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    /* <summary>
descripci�n de metodo:Se activa cuando otro objeto con un Collider sale del �rea del Collider de este objeto. 
    en el script PickUpObject del padre del Collider, indicando que ya no hay un objeto recogible en esa �rea.
</summary>*/
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
