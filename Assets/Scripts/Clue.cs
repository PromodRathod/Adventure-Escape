using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public AudioSource source;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        ui.SetActive(false);        //setting the panel as false initially
    }

    void OnTriggerEnter(Collider player)         //onTrigger function of box collider
    {
        if(player.gameObject.tag == "Player")
        {
            source.Play();
            ui.SetActive(true);                 //setting the panel as active
            StartCoroutine("WaitForSec");       //calling the IEnumerator function
        }
    }

    IEnumerator WaitForSec()                //IEnumerator here is used to pause the panel for required seconds 
    {
        yield return new WaitForSeconds(10);
        Destroy(ui);
        Destroy(gameObject);
        Destroy(source);
    }
}
