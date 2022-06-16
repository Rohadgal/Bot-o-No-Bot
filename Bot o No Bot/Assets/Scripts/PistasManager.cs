using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PistasManager : MonoBehaviour
{
    public TMP_Text textSiguiendo, textSeguidores;
    public Image imagenComentario1, imagenComentario2, imagenComentario3;
    public GameManager gameManager;
         
    // Start is called before the first frame update
    void Start()
    {
        textSiguiendo.text = gameManager.comentarios[0].seguidos.ToString();
        imagenComentario1.sprite = gameManager.comentarios[0].ultimoComentario1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarDatosPista()
    {

    }
}
