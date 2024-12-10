using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint;     
    public float fireRate = 0.5f;   
    private float nextFireTime = 0f; 
    public int can = 3;  
    private Animator animator;
    


    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            FireBullet();
            nextFireTime = Time.time + fireRate; 
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item")) 
        {
            
            Item item = other.GetComponent<Item>();
            if (item != null)
            {
                item.Collect();
            }
        }
    }


    void FireBullet()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void Ol()
    {
        
        can--;
        Debug.Log("Can Azaldý! Kalan Can: " + can);


        if (can == 0)
        {
            
            if (animator != null)
            {
                animator.SetTrigger("Ol");  
            }

            
            Debug.Log("Oyuncu Öldü!");
            
            Time.timeScale = 0; 
        }
        else
        {
            
            Debug.Log("Can Azaldý! Kalan Can: " + can);
        }
    }

}