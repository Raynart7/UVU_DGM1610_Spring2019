using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : GenericPickup {

    public GameObject PC;

        void onTriggerEnter2D(Collider2D other){
            if(other.name == "PC"){
                // player collects coins
            }
            else{
                // not player
            }
        }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
