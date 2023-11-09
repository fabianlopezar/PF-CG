
using UnityEngine;

public class MovimientoObj : MonoBehaviour
{
    public float speedH;
    public float speedV;

    float moveH;
    float moveV;

    private void OnMouseDrag()
    {
        moveH -= speedH * Input.GetAxis("Mouse X");
        //moveV += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0f, moveH, 0f);
    }

}//
