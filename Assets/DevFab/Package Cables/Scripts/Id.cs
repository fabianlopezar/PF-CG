using UnityEngine;
public class Id : MonoBehaviour
{
    public ManagerT a;
    public int idBloque;

    private void Start()
    {
        a = FindObjectOfType<ManagerT>();
        a.id = idBloque;
     //   Debug.Log("" + a.id);
    }
    //1. hacer dos niveles de cada uno en total 6 cajas de circuitos
    //2. hacer cronometro
    //3. hacer que la pile se llene
}
