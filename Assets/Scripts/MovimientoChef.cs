using UnityEngine;

public class MovimientoChef : MonoBehaviour
{
    public float velocidad = 4f;

    private Rigidbody2D rb;
    private float movimientoX;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");

        animator.SetBool("Caminando", movimientoX != 0);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);
    }
}
