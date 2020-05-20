using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    void OnTriggerEnter(Collider player)           //onTrigger function of box collider
    {
        if(player.gameObject.tag == "Player")       
        {
            SceneManager.LoadScene(0);
        }
    }
}
