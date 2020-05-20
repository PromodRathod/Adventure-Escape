using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysilverpopup : MonoBehaviour
{
    public GameObject cube;
    public AudioSource adsrc;
    // Start is called before the first frame update
    void Start()
    {
        adsrc = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            adsrc.Play();
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()                //IEnumerator here is used to pause the panel for required seconds 
    {
        yield return new WaitForSeconds(2);
        Destroy(adsrc);
        Destroy(cube);
    }
}
