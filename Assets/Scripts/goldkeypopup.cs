using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldkeypopup : MonoBehaviour
{
    public GameObject cube;
    public AudioSource audi;
    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audi.Play();
            StartCoroutine("WaitForSec");
        }
    }
    
    IEnumerator WaitForSec ()
    {
        yield return new WaitForSeconds(2);
        Destroy(audi);
        Destroy(cube);
    }
}
