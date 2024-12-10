using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float screenBoundaryPadding = 0.5f; 

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -10.5f, 10.5f); 
        newPosition.y = Mathf.Clamp(newPosition.y, -3.5f, 3.5f);  
        rb.MovePosition(newPosition);
    }
}
public class PlayerHealth : MonoBehaviour
{
    public int health = 3; 

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Oyuncu öldü!");
        }
    }
}