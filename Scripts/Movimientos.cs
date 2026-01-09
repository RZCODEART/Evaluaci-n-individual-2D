using Unity.Mathematics;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Movimientos : MonoBehaviour
{
    public float velocidad = 5f;
    private float velocidadX;
    private Vector2 posicionActual;
    [SerializeField] private SpriteRenderer sprite;
    private Animator animator;

    public float fuerzaSalto = 10f;
    public LayerMask suelo;
    public float logitudRayo;
    private bool enSuelo;
    private Rigidbody2D guerrero;

    private bool saltoPress;
   
    
    private bool atacar;



    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        guerrero = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        movimiento();
        
        
        ataque();
       

       
    }
    private void FixedUpdate()
    {
       


    }

    void movimiento()
    {
        //Movimiento -------------------------------------------------------------------------------

        velocidadX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        posicionActual = transform.position;
        transform.position = new Vector2(velocidadX + posicionActual.x, posicionActual.y);

        
        if (velocidadX > 0)
        {
            sprite.flipX = false;
            animator.SetBool("idle", false);
            animator.SetBool("run", true);
        }
        else if (velocidadX == 0 )
        {
            animator.SetBool("idle", true);
            animator.SetBool("run", false);
        }

        if (velocidadX < 0)
        {
            sprite.flipX = true;
            animator.SetBool("idle", false);
            animator.SetBool("run", true);

        }

        // Salto ----------------------------------------------------------------------------------------------

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, logitudRayo, suelo);
        enSuelo = hit.collider != null;

        saltoPress = Input.GetKeyDown(KeyCode.Space);

        if (enSuelo && saltoPress)
        {
            
            guerrero.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
            
        }
        animator.SetBool("ensuelo", enSuelo);
        


    }
   
     /// Ataque.... ---------------------------------------------------------

    public void Atacando()
    {
        atacar = true;
    }
    public void DesactivaAtaque()
    {
        atacar = false;
    }

    public void ataque()
    {

        
        if (Input.GetKeyDown(KeyCode.X) && !atacar && enSuelo)
        {
            Atacando();
        }

        animator.SetBool("atacar", atacar);

    }

    /// ---------------------------------------------------


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * logitudRayo);

    }

   









}
