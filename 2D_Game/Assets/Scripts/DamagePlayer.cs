using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour{

    public int damage;


public void OnTriggerEnter2D(Collider2D other){
    if(other.GetComponent <PlayerHealth>() != null){
        other.GetComponent <PlayerHealth> ().ChangeHealth(damage);
    
    }
}





}