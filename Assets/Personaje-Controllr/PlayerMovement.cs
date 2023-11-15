/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicolás donneys Alvarado 2211348
 */
//https://youtu.be/RCKogZqlgDk
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _runSpeed = 7;
    /* <summary>
     Descripcion del atributo: Este es un atributo público que define la velocidad de avance del jugador.
     </summary>*/
    public float _rotationSpeed = 250;
    /* <summary>
     Descripcion del atributo:Este atributo público determina la velocidad de rotación del jugador.
     </summary>*/
    public Animator animator;
    /* <summary>
     Descripcion del atributo:Una referencia pública al componente Animator del jugador que se utiliza
    para controlar las animaciones basadas en el movimiento del personaje.
     </summary>*/
    public float x, y;
    /* <summary>
     Descripcion del atributo:Estos atributos públicos representan, 
    respectivamente, la entrada horizontal y vertical que se utilizarán para mover y rotar al jugador.
     </summary>*/


    void Update()
    /* <summary>
 Descripcion del metodo:Update es un método especial de Unity que se llama en cada cuadro del juego. Se utiliza para llamar al método Movimiento en este caso.

 </summary>*/
    {
        Movimiento();
    }

    private void Movimiento()
    /* <summary>
 Descripcion del metodo:Este es un método privado que maneja la lectura de las entradas del usuario (a través de las teclas
    de movimiento horizontal y vertical), aplicando rotación y traslación al transform del jugador para moverlo en la escena. Además, actualiza los parámetros del
    Animator con los valores de las entradas para reflejar el movimiento del personaje en las animaciones.
 </summary>*/
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * _rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * _runSpeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}
