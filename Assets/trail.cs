using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trail : MonoBehaviour
{
    private int num;
    public GameObject input;
    public GameObject text;
    public GameObject panel;

    void Start () {
        text.SetActive(false);
        input.SetActive(false);
        panel.SetActive(false);
    }
    
    void Awake () {
        num = Random.Range(0,100);
    }

    public void GetInput (string guess) {
        CompareGuesses(int.Parse(guess));
        input.GetComponent<InputField>().text = "";
    }

    void OnTriggerEnter(Collider player)         //onTrigger function of box collider
    {
        if(player.gameObject.tag == "Player")
        {
            text.SetActive(true);
            input.SetActive(true);
            panel.SetActive(true);
        }
    }

    void CompareGuesses (int guess) {
        if (guess == num) {
            text.GetComponent<Text>().text = "You Guessed Correctly";
        }
        else if (guess < num) {
            text.GetComponent<Text>().text = "You Guess Number Is Less Than The Number You Are Tying To Guess";
        }
        else if (guess > num) {
            text.GetComponent<Text>().text = "You Guess Number Is Greater Than The Number You Are Tying To Guess";
        }
        else {
            text.GetComponent<Text>().text = "You Guess Number Is Not In The Range of 1 To 100";
        }
    }
}

