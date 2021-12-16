using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    public static Estado estado;
    public static int idUsuario;

    private void Awake()
    {
        if (estado == null)
        {
            estado=this;
            DontDestroyOnLoad(gameObject);
        }else if (estado != this)
        {
            Destroy(gameObject);
        }
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
