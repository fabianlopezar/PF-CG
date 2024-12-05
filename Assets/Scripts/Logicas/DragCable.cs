using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCable : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()
    {
        // Verificar si Camera.main no es null
        if (Camera.main != null)
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        }
        else
        {
            Debug.LogError("No se encontró la cámara principal.");
        }
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = GetMouseAsWorldPoint() + mOffset;

        // Limitar el movimiento al eje Z e Y
        newPosition.x = transform.position.x;

        // Aplicar la nueva posición
        transform.position = newPosition;
    }
}
