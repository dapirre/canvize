using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; 

    private void Start()
    {
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);

        }

    }
}
