using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Usuario> comentarios = new List<Usuario>();


    // Start is called before the first frame update
    void Start()
    {
        Usuario nuevoUsuario = new Usuario();
        comentarios.Add(nuevoUsuario);
        comentarios.RemoveAt(0);

        Random.Range(0, comentarios.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
