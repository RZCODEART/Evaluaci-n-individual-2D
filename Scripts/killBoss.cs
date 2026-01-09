using UnityEngine;

public class killBoss : MonoBehaviour
{


    public GameObject bomba;
    public Animator animator;
    public GameObject cofre;
    //private Gamemanager gamemanager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (cofre != null)
        {
            cofre.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Guerrero"))
            
        {
            animator.SetBool("boom", true);
            ActivarCofre();
            Destroy(bomba); 
        }

        
    }

    void ActivarCofre()
    {
        if (cofre != null)
        {
            cofre.SetActive(true);
            Debug.Log("¡El cofre ha aparecido!");
        }
    }
}



