/* <summary>
Integrantes:
Fabian Esteban Lopez Arias - 2216110
Sebastián Rivas Jiménez -2220715
Carlos Andres Garzon Guerrer 2220968
Johann Alberto Bocanegra Meusburger - 2200850
</summary>*/
using UnityEngine;

public class CamaraThirdPerson : MonoBehaviour
{
    public Vector3 offset;
    /* <summary>
descripción de atributo:Define el desplazamiento relativo de la cámara con respecto al objetivo (target).
    Este desplazamiento determina dónde se posiciona la cámara en relación con el objetivo.
</summary>*/
    private Transform target;
    /* <summary>
descripción de atributo: Es una referencia al Transform del objeto que la cámara sigue,
    normalmente el jugador. Se establece en el método Start.
</summary>*/
    [Range(0, 1)] public float lerpValue;
    /* <summary>
descripción de atributo:Un valor entre 0 y 1 que determina la suavidad con la que la cámara sigue al objetivo. 
    Se utiliza en la interpolación lineal (Lerp) para suavizar el movimiento de la cámara.
</summary>*/
    public float sensibilidad;
    /* <summary>
descripción de atributo:Controla la sensibilidad de la cámara a los movimientos del ratón.
    Afecta a cómo la cámara rota alrededor del objetivo cuando se mueve el ratón.
</summary>*/
    // Start is called before the first frame update
    void Start()
    /* <summary>
descripción de metodo:Se ejecuta antes del primer frame del juego. Aquí se inicializa la referencia target buscando y obteniendo el Transform del objeto "Player".
</summary>*/
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    /* <summary>
descripción de metodo:Se llama en cada frame del juego. Actualiza la posición de la cámara utilizando Vector3.
    Lerp para suavizar el movimiento hacia la posición del objetivo más el desplazamiento (offset).
    También ajusta el offset basado en el movimiento del ratón (eje X) multiplicado por la sensibilidad,
    permitiendo que la cámara rote alrededor del objetivo.
    Finalmente, la cámara siempre se orienta para mirar hacia el objetivo con transform.LookAt.
</summary>*/
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up )* offset;

        transform.LookAt(target);
    }
}
