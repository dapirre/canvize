using UnityEngine;
using System.Collections;

public class StillEnemy : MonoBehaviour
{
    public GameObject topPrefab;      
    public float atisGucu = 10f;      
    public float atisAraligi = 1f;    
    private Animator animator;         

    void Start()
    {
        animator = GetComponent<Animator>();  
        StartCoroutine(TopFirlamaCoroutine()); 
    }

    IEnumerator TopFirlamaCoroutine()
    {
        while (true)  
        {
            TopFirlat();  
            yield return new WaitForSeconds(atisAraligi);  
        }
    }

    void TopFirlat()
    {
        float randomX = Random.Range(-1f, 1f);  
        float randomY = Random.Range(-1f, 1f);  
        Vector2 randomDirection = new Vector2(randomX, randomY).normalized;  
        GameObject top = Instantiate(topPrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = top.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = randomDirection * atisGucu;
        }

        if (animator != null)
        {
            animator.SetTrigger("Firlama"); 
        }
    }
}
