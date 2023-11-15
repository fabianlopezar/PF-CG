/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebastián Rivas Jiménez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;
public class Player : MonoBehaviour
{


    public float velocidadMovimiento = 5.0f;
    /* <summary>
     descripción de atributo:Define la velocidad de movimiento del personaje.
    </summary>*/
    public float velocidadRotacion = 200.0f;
    /* <summary>
     descripción de atributo:Especifica la velocidad de rotación del personaje.
    </summary>*/
    public Animator anim;
    /* <summary>
     descripción de atributo:Referencia al componente Animator del personaje, utilizado para controlar las animaciones.
    </summary>*/
    public float x, y;
    /* <summary>
     descripción de atributo:Variables para almacenar los valores de entrada del movimiento horizontal (x) y vertical (y).
    </summary>*/

    public float jumpForce = 5.0f; // Fuerza del salto
    /* <summary>
     descripción de atributo:La fuerza aplicada cuando el personaje salta.
    </summary>*/
    private Rigidbody rb;
    /* <summary>
     descripción de atributo: Referencia al componente Rigidbody del personaje, utilizado para la física.
    </summary>*/
    private bool isGrounded = true;
    /* <summary>
     descripción de atributo:Indica si el personaje está tocando el suelo.
    </summary>*/

    private bool acti = false;
    /* <summary>
     descripción de atributo:Un interruptor para activar o desactivar una acción (en este caso, la danza).
    </summary>*/

    private void Start()
    /* <summary>
 descripción de metodo: Un método de inicialización que se llama al principio. Aquí se obtienen las referencias a los componentes Rigidbody y Animator.
</summary>*/
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    public void Update()
    /* <summary>
descripción de metodo:Se llama en cada frame del juego. Gestiona la entrada del jugador, mueve y rota el personaje, y actualiza las animaciones en función de los movimientos.
</summary>*/
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.X))
        {
            Dance();
        }
    }

    void Dance()
    /* <summary>
descripción de metodo:Un método para controlar la animación de danza del personaje. Alterna el estado de la variable acti y actualiza el Animator.
</summary>*/
    {
        acti = !acti;
        anim.SetBool("Dance", acti);
    }

}