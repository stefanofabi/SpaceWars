using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLimits : MonoBehaviour
{
    private Transform theTransform = null;
    public Vector2 horizontalRange = Vector2.zero;      // limite izquierdo, limite derecho
    public Vector2 verticalRange = Vector2.zero;        // limite superior, limite inferior

    // se llama unica y exclusivamente cuando se crea la nave
    void Awake() {
        theTransform = GetComponent<Transform> ();
    }

    // actualizacion tardia, se llama 1 vez por renderizado, 1xfps
    // se llama despues del fixedupdate y despues del update
    // nos permite que si despues de modificar la posicion de la nave asegurarnos que no desaparece de la pantalla
    void LateUpdate() {
        theTransform.position = new Vector3(
            Mathf.Clamp(theTransform.position.x, horizontalRange.x, horizontalRange.y),
            theTransform.position.y,
            Mathf.Clamp(theTransform.position.z, verticalRange.x, verticalRange.y)
        );
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
