using UnityEngine;

public class DisparoChef : MonoBehaviour
{
    public GameObject proyectil;
    public Transform puntoDisparo;
    public float velocidadDisparo = 8f;
    private Animator animator;

    void Start()
{
    animator = GetComponent<Animator>();
}

    void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        animator.SetTrigger("Disparar");
        Disparar();
    }
}

    void Disparar()
{
    GameObject nuevoProyectil =
        Instantiate(proyectil, puntoDisparo.position, Quaternion.identity);

    Rigidbody2D rb = nuevoProyectil.GetComponent<Rigidbody2D>();

    float direccion = Mathf.Sign(
        puntoDisparo.position.x - transform.position.x
    );

    rb.linearVelocity = new Vector2(
        direccion * velocidadDisparo,
        0f
    );

    Destroy(nuevoProyectil, 5f);
}
}


