    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonJuego()
    {
        SceneManager.LoadScene("Partida");
    }
    public void BotonInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }
    public void BotonCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void BotonVolver()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void Bot()
    {
        int Bot = 1;
        gameManager.ChecadorRespuesta(Bot);
    }

    public void NoBot()
    {
        int noBot = 0;
        gameManager.ChecadorRespuesta(noBot);
    }
}
