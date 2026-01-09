using TMPro;
using UnityEngine;

public class Winner : MonoBehaviour
{

    public TextMeshProUGUI Win;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Guerrero"))
        {
            print("winner");
            animator.SetBool("Winner", true);
            Win.enabled = true; 
            
        }
    }




}
