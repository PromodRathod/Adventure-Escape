using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl3guesscontroller : MonoBehaviour
{
    public AudioSource source;
    private int num;
    public GameObject input;
    public GameObject quiz;
    public GameObject panel;
    
    void Start () {
        source = GetComponent<AudioSource>();
        quiz.SetActive(false);
        input.SetActive(false);
        panel.SetActive(false);
    }

    void Awake () {
        num = Random.Range(0,100);
    }

    public void GetInput (string guess) {
        CompareGuesses (int.Parse(guess));
        input.GetComponent<InputField>().text = "";
    }

    void OnTriggerEnter(Collider player)         //onTrigger function of box collider
    {
        if(player.gameObject.tag == "Player")
        {
            quiz.SetActive(true);
            input.SetActive(true);
            panel.SetActive(true);
        }
    }

    void CompareGuesses (int g) {
        if (g == num) {
            quiz.GetComponent<Text>().text = "You Guessed Correctly";
            source.Play();
            StartCoroutine("WaitForSec");
        }
        else if (g < num) {
            quiz.GetComponent<Text>().text = "You Guess Number Is Less Than The Number You Are Tying To Guess";
        }
        else if (g > num) {
            quiz.GetComponent<Text>().text = "You Guess Number Is Greater Than The Number You Are Tying To Guess";
        }
        else {
            quiz.GetComponent<Text>().text = "You Guess Number Is Not In The Range of 1 To 100";
        }
    }

    IEnumerator WaitForSec () {
        yield return new WaitForSeconds(2);
        Destroy(panel);
        Destroy(gameObject);
        Destroy(quiz);
        Destroy(input);
    }
}
