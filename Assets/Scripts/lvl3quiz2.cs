using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl3quiz2 : MonoBehaviour
{
    public AudioSource source;
    public GameObject panel;
    public GameObject input;
    public GameObject text;
    private string ans = "stamp";

    void Start () {
        source = GetComponent<AudioSource>();
        panel.SetActive(false);
        input.SetActive(false);
        text.SetActive(false);
    }

    public void GetInput (string answer) {
        Compare(answer);
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

    void Compare (string answer) {
        if (string.Compare(ans,answer) == 0) {
            text.GetComponent<Text>().text = "You Guessed it Correctly";
            source.Play();
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec () {
        yield return new WaitForSeconds(2);
        Destroy(panel);
        Destroy(gameObject);
        Destroy(text);
        Destroy(input);
    }
}
