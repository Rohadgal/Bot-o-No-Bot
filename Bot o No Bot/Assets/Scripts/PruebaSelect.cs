using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PruebaSelect : MonoBehaviour
{
    public GameManager gameManager;
    public Text siguiendo;
    public Image perfil;
    // Start is called before the first frame update
    void Start()
    {
        siguiendo.text = gameManager.RandomEleccion().comentario;
        //gameManager.ChecadorRespuesta();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
