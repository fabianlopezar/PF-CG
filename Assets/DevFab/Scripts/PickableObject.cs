using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;
    public float peso;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Mano")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
