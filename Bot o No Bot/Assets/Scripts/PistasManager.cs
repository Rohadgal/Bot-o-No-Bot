using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PistasManager : MonoBehaviour
{
    public TMP_Text textSiguiendo, textSeguidores;
    public Image imagenComentario1, imagenComentario2, imagenComentario3, fotoDePerfil;
    public GameManager gameManager;
         
    // Start is called before the first frame update
    void Start()
    {
        CambiarDatosPista();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarDatosPista()
    {
        textSiguiendo.text = "Siguiendo " + gameManager.comentarios[0].seguidos.ToString();
        textSeguidores.text = "Seguidores " + gameManager.comentarios[0].seguidores.ToString();
        imagenComentario1.sprite = gameManager.comentarios[0].ultimoComentario1;
        imagenComentario2.sprite = gameManager.comentarios[0].ultimoComentario2;
        imagenComentario3.sprite = gameManager.comentarios[0].ultimoComentario3;
        fotoDePerfil.sprite = gameManager.comentarios[0].fotoDePerfil;
    }
}
