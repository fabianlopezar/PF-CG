using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject ball;
    public Transform Camera;
    public float ballDistance = 2f;
    public float ballForce = 250f;
    public float RayDistanceMIN=0f;
    public float RayDistanceMAX;
    bool holdingBall = true;
    Rigidbody ballRB;


    bool isPickableball = false;
    public CanvasController canvasScript;

    public LayerMask pickableLayer;
    RaycastHit hit;

    private void Start()
    {
        ballRB = ball.GetComponent<Rigidbody>();
        ballRB.useGravity = false;
        canvasScript.OcultarCursor(true);

    }
    // Update is called once per frame
    void Update()
    {

        if (holdingBall == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ballRB.useGravity = true;
                ballRB.AddForce(Camera.forward * ballForce);

                canvasScript.OcultarCursor(false);


            }
        }
        else
        {
            if(Physics.Raycast(Camera.position,Camera.TransformDirection(Vector3.forward),out hit,Mathf.Max(RayDistanceMIN,RayDistanceMAX), pickableLayer))
            {
                if (isPickableball == false)
                {
                    isPickableball = true;
                    canvasScript.ChangePickableBallColor(true);

                }
                if(isPickableball && Input.GetKeyDown(KeyCode.E))
                {
                    holdingBall = true;
                    ballRB.useGravity = false;
                    ballRB.velocity = Vector3.zero;
                    ball.transform.localRotation = Quaternion.identity;
                    canvasScript.ChangePickableBallColor(true);
                    canvasScript.OcultarCursor(true);

                }
            }else if(isPickableball== true)
            {
                isPickableball = false;
                canvasScript.ChangePickableBallColor(false);

            }
        }
     }
    
    private void LateUpdate()
{
        if (holdingBall == true)
        {

            ball.transform.position = Camera.position + Camera.forward * ballDistance;
        }
    }

}
