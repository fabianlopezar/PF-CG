using UnityEngine;
// 12:12
public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mano")
        {
            Debug.Log("D");
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
        }
    }
}
