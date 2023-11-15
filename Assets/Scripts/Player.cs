/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebasti�n Rivas Jim�nez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;
public class Player : MonoBehaviour
{


    public float velocidadMovimiento = 5.0f;
    /* <summary>
     descripci�n de atributo:Define la velocidad de movimiento del personaje.
    </summary>*/
    public float velocidadRotacion = 200.0f;
    /* <summary>
     descripci�n de atributo:Especifica la velocidad de rotaci�n del personaje.
    </summary>*/
    public Animator anim;
    /* <summary>
     descripci�n de atributo:Referencia al componente Animator del personaje, utilizado para controlar las animaciones.
    </summary>*/
    public float x, y;
    /* <summary>
     descripci�n de atributo:Variables para almacenar los valores de entrada del movimiento horizontal (x) y vertical (y).
    </summary>*/

    public float jumpForce = 5.0f; // Fuerza del salto
    /* <summary>
     descripci�n de atributo:La fuerza aplicada cuando el personaje salta.
    </summary>*/
    private Rigidbody rb;
    /* <summary>
     descripci�n de atributo: Referencia al componente Rigidbody del personaje, utilizado para la f�sica.
    </summary>*/
    private bool isGrounded = true;
    /* <summary>
     descripci�n de atributo:Indica si el personaje est� tocando el suelo.
    </summary>*/

    private bool acti = false;
    /* <summary>
     descripci�n de atributo:Un interruptor para activar o desactivar una acci�n (en este caso, la danza).
    </summary>*/

    private void Start()
    /* <summary>
 descripci�n de metodo: Un m�todo de inicializaci�n que se llama al principio. Aqu� se obtienen las referencias a los componentes Rigidbody y Animator.
</summary>*/
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    public void Update()
    /* <summary>
descripci�n de metodo:Se llama en cada frame del juego. Gestiona la entrada del jugador, mueve y rota el personaje, y actualiza las animaciones en funci�n de los movimientos.
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
descripci�n de metodo:Un m�todo para controlar la animaci�n de danza del personaje. Alterna el estado de la variable acti y actualiza el Animator.
</summary>*/
    {
        acti = !acti;
        anim.SetBool("Dance", acti);
    }

}