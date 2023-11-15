/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebasti�n Rivas Jim�nez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class CamaraThirdPerson : MonoBehaviour
{
    public Vector3 offset;
    /* <summary>
descripci�n de atributo:Define el desplazamiento relativo de la c�mara con respecto al objetivo (target).
    Este desplazamiento determina d�nde se posiciona la c�mara en relaci�n con el objetivo.
</summary>*/
    private Transform target;
    /* <summary>
descripci�n de atributo: Es una referencia al Transform del objeto que la c�mara sigue,
    normalmente el jugador. Se establece en el m�todo Start.
</summary>*/
    [Range(0, 1)] public float lerpValue;
    /* <summary>
descripci�n de atributo:Un valor entre 0 y 1 que determina la suavidad con la que la c�mara sigue al objetivo. 
    Se utiliza en la interpolaci�n lineal (Lerp) para suavizar el movimiento de la c�mara.
</summary>*/
    public float sensibilidad;
    /* <summary>
descripci�n de atributo:Controla la sensibilidad de la c�mara a los movimientos del rat�n.
    Afecta a c�mo la c�mara rota alrededor del objetivo cuando se mueve el rat�n.
</summary>*/
    // Start is called before the first frame update
    void Start()
    /* <summary>
descripci�n de metodo:Se ejecuta antes del primer frame del juego. Aqu� se inicializa la referencia target buscando y obteniendo el Transform del objeto "Player".
</summary>*/
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    /* <summary>
descripci�n de metodo:Se llama en cada frame del juego. Actualiza la posici�n de la c�mara utilizando Vector3.
    Lerp para suavizar el movimiento hacia la posici�n del objetivo m�s el desplazamiento (offset).
    Tambi�n ajusta el offset basado en el movimiento del rat�n (eje X) multiplicado por la sensibilidad,
    permitiendo que la c�mara rote alrededor del objetivo.
    Finalmente, la c�mara siempre se orienta para mirar hacia el objetivo con transform.LookAt.
</summary>*/
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up )* offset;

        transform.LookAt(target);
    }
}
