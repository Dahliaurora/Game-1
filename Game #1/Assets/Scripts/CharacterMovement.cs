using UnityEngine;

public class Character_Movement : MonoBehaviour
{	
	private float movementSpeed = 5f;
	private Rigidbody2D rb;
	private Vector2 movementDirection;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection.normalized * movementSpeed;
    }
}
