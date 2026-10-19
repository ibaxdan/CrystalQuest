using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 7f;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

void FixedUpdate()
{
    Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

    // Si nos estamos moviendo, girar hacia esa dirección
    if (direction != Vector3.zero)
    {
        transform.forward = direction;
    }

    Vector3 velocity = rb.linearVelocity; // o rb.velocity si usas versión anterior
    velocity.x = direction.x * speed;
    velocity.z = direction.z * speed;

    rb.linearVelocity = velocity;
}
}