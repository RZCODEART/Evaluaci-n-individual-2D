using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class controlerCamera : MonoBehaviour
{
    public CinemachineCamera camera1;
    public CinemachineCamera camera2;
    private bool activa = false;
    void Start()
    {
        camera1.Priority = 1; 
        camera2.Priority = 2;

    }

    // Update is called once per frame
    void Update()
    {
        controlCamera();
    }
    void controlCamera()
    {
        if ( Input.GetKeyDown(KeyCode.C))
        {
            activa = !activa;

            if (activa)
            {
                camera1.Priority = 2;
                camera2.Priority = 1;

                print("CambioActivado");

            }
            else

            {
                camera1.Priority = 1;
                camera2.Priority = 2;
                print("CambioDesActivado");
            }
        }
    }

}