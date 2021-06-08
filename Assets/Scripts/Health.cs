using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject deathParticlesPrefab = null;
    private Transform theTransform = null;
    public bool shouldBeDestroyedOnDeath = true;
    public bool shouldShowGameOverOnDeath = false;
    // propiedad en c#
    // programacion orientada a eventos
    public float healthPoints {
        get {
            return _healthPoints;
        }

        set {
            _healthPoints = value;

            if (_healthPoints <= 0) {
                // le enviamos un mensaje a todos los componentes del gameobject
                // lo ejecutaran solo los componentes que contengan esta implementacion
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);

                // si le configuramos algun efecto al morir este se reproducira en este momento
                if (deathParticlesPrefab != null) {
                    Transform rotacionDePrefab = theTransform;
                    //rotacionDePrefab = GameObject.FindGameObjectWithTag("ExplosionCasera").GetComponent<Transform>();
                    rotacionDePrefab.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
                    
                    Instantiate(deathParticlesPrefab, theTransform.position, rotacionDePrefab.rotation);

                    // eliminamos el objeto de la pantalla
                    if (shouldBeDestroyedOnDeath) {
                        Destroy(gameObject);
                    }
                }
                if (shouldShowGameOverOnDeath == true)
                {
                    GameController.GameOver();
                }
                {

                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        theTransform = GetComponent<Transform> ();
    }

    // Update is called once per frame
    void Update()
    {
        // me convierto en kamikaze para probar el destroy
        if (Input.GetKeyDown(KeyCode.Space)) {
            healthPoints = 0;
        }
    }

    [SerializeField]
    private float _healthPoints = 100.0f;
}
