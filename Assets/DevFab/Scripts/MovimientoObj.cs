/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebastián Rivas Jiménez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class MovimientoObj : MonoBehaviour
{
    public float speedH;
    /* <summary>
descripción de atributo:Velocidad horizontal del objeto.
    Controla qué tan rápido se mueve el objeto en respuesta al movimiento horizontal del mouse.
</summary>*/
    public float speedV;
    /* <summary>
descripción de atributo:Velocidad vertical del objeto. Aunque está presente en el código,
    actualmente no se utiliza para controlar el movimiento vertical del objeto.
</summary>*/

    float moveH;
    /* <summary>
descripción de atributo:Almacena el movimiento horizontal acumulado.
    Se actualiza en función del movimiento del mouse y la velocidad horizontal.
</summary>*/
    float moveV;
    /* <summary>
descripción de atributo:Almacena el movimiento vertical acumulado. Aunque está definido, no se utiliza en el método actual.
</summary>*/

    private void OnMouseDrag()
    /* <summary>
descripción de metodo:Este método se activa cuando el usuario arrastra el objeto con el mouse. Utiliza la velocidad horizontal
    (speedH) y el movimiento horizontal del mouse (Input.GetAxis("Mouse X")) para calcular el nuevo ángulo de rotación horizontal
    del objeto (moveH). Luego, aplica esta rotación al objeto.
    La parte del código para el movimiento vertical está comentada y por lo tanto no se ejecuta.
</summary>*/
    {
        moveH -= speedH * Input.GetAxis("Mouse X");
        //moveV += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0f, moveH, 0f);
    }

}
