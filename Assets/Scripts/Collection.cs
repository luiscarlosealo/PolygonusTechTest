using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public GameObject collectionEffect;
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Coin") 
        {

            Instantiate(collectionEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject); 

        }
    }
}
