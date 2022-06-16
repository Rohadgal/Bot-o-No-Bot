using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public recorrido casillas;
    public Transform target;
    public Transform npctarget;
    public float speed;
    public float npcspeed;
    public GameObject player;
    public GameObject npc;
    public GameObject playerImage;
    public GameObject npcImage;
    public CanvasGroup youWin;
    public CanvasGroup youLose;
    bool playerWin;
    bool npcWin;
    float m_Timer;


    void Start()
    {
        playerImage.SetActive(false);
        npcImage.SetActive(false);
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject == player)
        {
             playerImage.SetActive(true);
             playerWin = true;
        }

        if (collision.gameObject == npc)
        {
             npcImage.SetActive(true);
             npcWin = true;
        }

        
    }


    void Update()
    {

        if (casillas.index == 6)
        {
            playerImage.SetActive(true);
            float step = speed * Time.deltaTime;
            casillas.playerMove.transform.position = Vector2.MoveTowards(casillas.playerMove.transform.position, target.position, step);
        }

        if (casillas.index2 == 6)
        {
            npcImage.SetActive(true);
            float npcstep = speed * Time.deltaTime;
            casillas.npcMove.transform.position = Vector2.MoveTowards(casillas.npcMove.transform.position, target.position, npcstep);
        }

        if (playerWin)
        {
            EndLevel(youWin, true);
        }
        else if (npcWin)
        {
            EndLevel(youLose, true);
        }
    }

    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart)
    {
        
        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                Application.Quit();
            }
        }
    }
}
