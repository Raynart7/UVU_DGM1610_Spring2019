using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Grab : MonoBehaviour{

    public int coinValue;

    void OnTriggerEnter2D (Collider2D other){
        if(other.tag == "Player"){

            ScoreManager.AddPoints(coinValue);

            Destroy(gameObject);
        
        }
    }


    


}