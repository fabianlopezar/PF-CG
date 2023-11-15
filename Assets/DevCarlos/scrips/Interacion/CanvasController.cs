using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    public Image ImageSelector;



    public void ChangePickableBallColor(bool isSelect)
    {
        if (isSelect)
        {
            ImageSelector.color = Color.green;

        }
        else
        {
            ImageSelector.color = Color.white;

        }
    }
    public void OcultarCursor(bool ocultar)
    {
        ImageSelector.enabled = !ocultar;
    }
}
