using UnityEngine;

public class CambioEscenaTrigger : MonoBehaviour
{
    public string _nameSceneToChange;
    private void OnTriggerEnter(Collider other)
    {
        //cambiar de esena
        if (other.CompareTag("Player"))
        {
            ChangeLevel.Instance.ChangeScene(_nameSceneToChange);
        }
    }
}
