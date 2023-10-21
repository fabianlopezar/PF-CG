using UnityEngine;
public class Player : MonoBehaviour
{
 
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public Animator anim;
    public float x, y;

    public float jumpForce = 5.0f; // Fuerza del salto
    private Rigidbody rb;
    private bool isGrounded = true;

    private bool acti = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.X))
        {
            Dance();
        }
    }

    void Dance()
    {
        acti = !acti;
        anim.SetBool("Dance", acti);
    }

}