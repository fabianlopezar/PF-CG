/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebastián Rivas Jiménez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;
    /* <summary>
     descripción de atributo: Determina si el objeto puede ser recogido o no. Es verdadero (true) si el objeto está disponible para ser recogido.
    </summary>*/
    public float peso;
    /* <summary>
     descripción de atributo: Representa el peso del objeto. Este atributo podría usarse para limitar qué objetos puede recoger el jugador en función
    de su capacidad o para afectar la física del objeto.
    </summary>*/

    private void OnTriggerEnter(Collider other)
    /* <summary>
descripción de metodo:Este método se activa cuando otro objeto con un Collider entra en el área del Collider de este objeto
    (que se supone es un Trigger). Si el objeto entrante tiene la etiqueta "Mano", se actualiza la referencia del objeto 
    que puede ser recogido
    (ObjectToPickUp) en el script PickUpObject del padre del Collider, señalando a este objeto como recogible.
</summary>*/
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    /* <summary>
descripción de metodo:Se activa cuando otro objeto con un Collider sale del área del Collider de este objeto. 
    en el script PickUpObject del padre del Collider, indicando que ya no hay un objeto recogible en esa área.
</summary>*/
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
