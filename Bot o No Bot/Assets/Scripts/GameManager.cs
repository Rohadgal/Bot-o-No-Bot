using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Usuario> comentarios = new List<Usuario>();
    public Usuario currentUsuario;
    public recorrido recorrido1;
    public Text comentario, puntaje;
    public Button botonDePistas, botonNoBot, botonBot;
    private int comentarioActual, contadorJugador=0, contadorBot=0;
    private int puntosJugador=0, puntosBot=0, turnosCorrectos=0;

    // Start is called before the first frame update
    void Start()
    {
        RandomEleccion();
        
        puntaje.text = "Jugador: " + puntosJugador.ToString() + "\r\nBot: " + puntosBot.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Usuario RandomEleccion()
    {
        comentarioActual = Random.Range(0, comentarios.Count);
        currentUsuario = comentarios[comentarioActual];
        Debug.Log("Elección random");
        comentario.text = currentUsuario.comentario;

        if (turnosCorrectos >= 2)
            botonDePistas.interactable = true;

        return currentUsuario;   
    }

    public void ChecadorRespuesta(int eleccion)
    {
        StartCoroutine(ExampleCoroutine());

        if (currentUsuario.siEsBot && eleccion == 1 )
        {
            Debug.Log("Es bot");
            Debug.Log("Punto a favor para jugador");
            recorrido1.bottom();
            contadorJugador++;
            turnosCorrectos++;
            
            if (contadorJugador >= 2)
            {
                puntosJugador += 20;
            }
            else
            {
                puntosJugador += 10;
            }
        }

        else if(!currentUsuario.siEsBot && eleccion == 0)
        {
            Debug.Log("No es bot");
            Debug.Log("Punto para el jugador");
            recorrido1.bottom();
            turnosCorrectos++;

            contadorJugador++;
            if(contadorJugador>=2)
            {
                puntosJugador += 20;
            }
            else
            {
                puntosJugador += 10;
            }
        }

        else
        {
            Debug.Log("Punto para el bot");
            recorrido1.npcbottom();
            contadorJugador = 0;
            contadorBot++;
            turnosCorrectos = 0;
            botonDePistas.interactable = false;

            if (contadorBot >= 2)
            {
                puntosBot += 20;
            }
            else
            {
                puntosBot += 10;
            }
            
        }

        puntaje.text = "Jugador: " + puntosJugador.ToString() + "\r\nBot: " + puntosBot.ToString();
        comentarios.RemoveAt(comentarioActual);
        RandomEleccion();
        
    }

    IEnumerator ExampleCoroutine()
    {
        botonBot.interactable = false;
        botonNoBot.interactable = false;

        yield return new WaitForSeconds(0.5f);

        botonBot.interactable = true;
        botonNoBot.interactable = true;
    }
}
