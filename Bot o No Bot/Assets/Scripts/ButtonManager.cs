    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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
        SceneManager.LoadScene("Juego");
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
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
