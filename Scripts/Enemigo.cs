using UnityEngine;


public class Enemigo : MonoBehaviour
{


    private Animator animator;
    private Collider2D colision;
    private Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       animator = GetComponent<Animator>();    
       colision = GetComponent<Collider2D>();   
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Guerrero"))
        {
            print("golpeando");
            animator.SetBool("muerte", true);
            colision.enabled = false;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }




}
