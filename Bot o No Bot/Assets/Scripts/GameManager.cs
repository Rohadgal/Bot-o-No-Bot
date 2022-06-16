using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Usuario> comentarios = new List<Usuario>();
    public Usuario currentUsuario;

    // Start is called before the first frame update
    void Start()
    {
        RandomEleccion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Usuario RandomEleccion()
    {
        currentUsuario = comentarios[Random.Range(0, comentarios.Count)];
        Debug.Log("Elección random");

        return currentUsuario;
        
    }

    public void ChecadorRespuesta(int eleccion)
    {

        
        if(currentUsuario.siEsBot && eleccion == 1 )
        {
            Debug.Log("Es bot");
            Debug.Log("Punto a favor para jugador");
        }
        else if(!currentUsuario.siEsBot && eleccion == 0)
        {
            Debug.Log("No es bot");
            Debug.Log("Punto para el jugador");
        }
        else
        {
            Debug.Log("Punto para el bot");
        }
    }
}
