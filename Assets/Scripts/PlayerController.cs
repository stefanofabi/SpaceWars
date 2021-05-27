using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // para consultar propiedades fisicas del game object y evitar que la nave se vaya de la pantalla o traspase enemigos
    private Rigidbody theBody = null;

    // sabemos donde esta exactamente la nave
    private Transform theTransform = null;

    // para permitir al jugador moverse
    public bool mouseLook = true;

    // movimientos permitidos en el juego
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string fireAxis = "Fire1";

    // maxima velocidad de movimiento de la nave
    public float maxSpeed = 4.0f;

    // se llama unica y exclusivamente cuando se crea la nave
    void Awake() {
        theBody = GetComponent<Rigidbody> ();
        theTransform = GetComponent<Transform> ();
    }

    // representa la parte dinamica del juego, se llama en intervalos regulares de tiempo
    void FixedUpdate() {
        // actualizar el movimiento
        // son valores entre -1 y 1 
        // getAxis devuelve un numero entre -1 y 1
        // -1 indica izq - 1 indica derecha o abajo y arriba respectivamente en vertical
        float horizontal = Input.GetAxis(horizontalAxis);   // movimiento horizontal que realizo la nave
        float vertical = Input.GetAxis(verticalAxis);       // movimiento vertical que realizo la nave

        // aca congelamos Y para simular un juego 2D y Z para que no se mueva hacia arriba o abajo
        Vector3 direccionDelMovimiento = new Vector3(horizontal, 0, 0);

        // aplica una fuerza al rigidbody para desplazar la nave 
        theBody.AddForce(direccionDelMovimiento.normalized*maxSpeed);

        // actualizar la velocidad de la nave
        // aplicamos una fuerza a la velocidad de la nave dentro de un rango -maxSpeed y maxSpeed
        theBody.velocity = new Vector3(
            Mathf.Clamp(theBody.velocity.x, -maxSpeed, maxSpeed),
            Mathf.Clamp(theBody.velocity.y, -maxSpeed, maxSpeed),
            Mathf.Clamp(theBody.velocity.z, -maxSpeed, maxSpeed)
        );

        // rotacion de la nave 
        /*
        if (mouseLook) {
            // coordenadas de la pantalla, z=0 por ser un juego en 2D? 
            Vector3 mousePositionInScreen =  new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

            // ahora debo transformarlas a las coordenadas del mundo del juego
            Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionInScreen);

            // nos movemos solo por las coordenadas X-Z ya que Y la bloqueamos al ser 2D? 
            mousePositionInWorld = new Vector3(mousePositionInWorld.x, 0, mousePositionInWorld.z);

            // la diferencia entre donde esta el raton y donde esta la nave
            // es un vector que nos indica la direccion a donde rotar la nave
            Vector3 positionToLook = mousePositionInWorld - theTransform.position;
            theTransform.localRotation = Quaternion.LookRotation(positionToLook.normalized, Vector3.up);
        }
        */
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
