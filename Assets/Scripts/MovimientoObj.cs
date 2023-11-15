/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebasti�n Rivas Jim�nez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class MovimientoObj : MonoBehaviour
{
    public float speedH;
    /* <summary>
descripci�n de atributo:Velocidad horizontal del objeto.
    Controla qu� tan r�pido se mueve el objeto en respuesta al movimiento horizontal del mouse.
</summary>*/
    public float speedV;
    /* <summary>
descripci�n de atributo:Velocidad vertical del objeto. Aunque est� presente en el c�digo,
    actualmente no se utiliza para controlar el movimiento vertical del objeto.
</summary>*/

    float moveH;
    /* <summary>
descripci�n de atributo:Almacena el movimiento horizontal acumulado.
    Se actualiza en funci�n del movimiento del mouse y la velocidad horizontal.
</summary>*/
    float moveV;
    /* <summary>
descripci�n de atributo:Almacena el movimiento vertical acumulado. Aunque est� definido, no se utiliza en el m�todo actual.
</summary>*/

    private void OnMouseDrag()
    /* <summary>
descripci�n de metodo:Este m�todo se activa cuando el usuario arrastra el objeto con el mouse. Utiliza la velocidad horizontal
    (speedH) y el movimiento horizontal del mouse (Input.GetAxis("Mouse X")) para calcular el nuevo �ngulo de rotaci�n horizontal
    del objeto (moveH). Luego, aplica esta rotaci�n al objeto.
    La parte del c�digo para el movimiento vertical est� comentada y por lo tanto no se ejecuta.
</summary>*/
    {
        moveH -= speedH * Input.GetAxis("Mouse X");
        //moveV += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0f, moveH, 0f);
    }

}
