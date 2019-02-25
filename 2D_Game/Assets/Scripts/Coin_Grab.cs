using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Grab : MonoBehaviour{

    public int coinValue;

    void OnTriggerEnter2D (Collider2D other){
        if(other.name == "Player"){

            print("You've collected a coin");

            Destroy(gameObject);
        
        }
    }


    


}