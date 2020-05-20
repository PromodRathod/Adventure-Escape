using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startandquit : MonoBehaviour
{
    public void playgame () {       //start game button in the mainmenu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitgame () {       //quit game buttin in the mainmenu
        Debug.Log("Quit!!");        //print the text in the unity console
        Application.Quit();
    }
}
