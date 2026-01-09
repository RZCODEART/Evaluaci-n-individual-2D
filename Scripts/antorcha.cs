using UnityEngine;

public class antorcha : MonoBehaviour
{
    
    public int valor = 1;
    public Gamemanager gamemanager;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Guerrero"))
        {
            gamemanager.SumarPuntos(valor);
            Destroy(this.gameObject);



        }



    }


}
