using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Grab : MonoBehaviour{

    public int coinValue;

    void OnTriggerEnter2D (Collider2D other){
        if(other.tag == "Player"){

            print("You've collected String");

            ScoreManager.AddPoints(coinValue);

            Destroy(gameObject);
        
        }
    }


    


}