using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PistasManager : MonoBehaviour
{
    public TMP_Text textSiguiendo, textSeguidores, nombreUsuario;
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
        nombreUsuario.text = gameManager.currentUsuario.usuario;
        textSiguiendo.text = "Siguiendo " + gameManager.currentUsuario.seguidos.ToString();
        textSeguidores.text = "Seguidores " + gameManager.currentUsuario.seguidores.ToString();
        imagenComentario1.sprite = gameManager.currentUsuario.ultimoComentario1;
        imagenComentario2.sprite = gameManager.currentUsuario.ultimoComentario2;
        imagenComentario3.sprite = gameManager.currentUsuario.ultimoComentario3;
        fotoDePerfil.sprite = gameManager.currentUsuario.fotoDePerfil;
    }
}
