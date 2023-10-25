using UnityEngine;

public class CambioEscenaTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //cambiar de esena
        if (other.CompareTag("Player"))
        {
            ChangeLevel.Instance.Scena1();
        }
    }
}
