using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_PowerUp : MonoBehaviour
{
   
    public void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<PlayerHealth>() != null){
            other.GetComponent<PlayerHealth>().ChangeHealth(1);
            Destroy(gameObject);

        }



    }
}
