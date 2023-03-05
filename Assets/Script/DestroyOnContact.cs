using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject explosition;
    public GameObject playerExplosion;
    void OnTriggerEnter (Collider other){
        if(other.tag == "Boundary")
            return;
        Instantiate(explosition, transform.position, transform.rotation);
        if(other.tag == "Player"){
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}