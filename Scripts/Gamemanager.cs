using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;
    public TextMeshProUGUI puntos;
    

    //Singleton

    public static Gamemanager Instance;
    public int antorchaSpecial = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntos.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        // puntos.text = gameManager.PuntosTotales.ToString();
        puntos.text = puntosTotales.ToString();
    }

    public void SumarPuntos(int puntosASumar)
    {

        puntosTotales += puntosASumar + antorchaSpecial;
        print(puntosTotales);

    }



}