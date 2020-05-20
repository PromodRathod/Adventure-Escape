using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickanddrop : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown() {                                //inbuilt mouse down click function
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp() {                                 //inbuilt mouse down click function
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
    }
}
