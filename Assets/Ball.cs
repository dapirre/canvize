using UnityEngine;

public class Ball : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Player player = collision.gameObject.GetComponent<Player>();
            if (player != null)
            {
                player.Ol();  
            }
            Destroy(gameObject);
        }
    }
}
