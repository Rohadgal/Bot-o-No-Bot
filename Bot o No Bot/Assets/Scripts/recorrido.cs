using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recorrido : MonoBehaviour
{

    public Transform[] Casillas;
    public int index;
    public int index2;
    public GameObject npcMove;
    public GameObject playerMove;
    float npcTimer = 0.5f;
    public float timer = 0.5f;
    bool npctimeIsRunning;
    bool timeisrunning;

    void Start()
    {
        timeisrunning = true;
        npctimeIsRunning = true;
        
    }

    public void bottom()
    {
        timeisrunning = true;
        

    }

    public void npcbottom()
    {
        npctimeIsRunning = true;
       
    }



    void Update()
    {
        //Movimiento del jugador
            if (timeisrunning)
            {
                timer -= Time.deltaTime;


            }
            else
            {
                timer = 0.5f;
            }


            if (timer <= 0)
            {
                index++;
                playerMove.transform.position = Casillas[index].transform.position;
                timeisrunning = false;
                
            }

            if(index == 7)
            {
                index = -1;
            }

            //Movimiento del NPC

            if (npctimeIsRunning)
            {
                npcTimer -= Time.deltaTime;


            }
            else
            {
                npcTimer = 0.5f;
            }


            if (npcTimer <= 0)
            {
                index2++;
                npcMove.transform.position = Casillas[index2].transform.position;
                npctimeIsRunning = false;
                
            }

            if (index2 == 7)
            {
                index2 = -1;
            }

    }
}
