using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_PowerUp : MonoBehaviour{


    public int ammoAmount;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Player_Ammo>() != null)
        {
            other.GetComponent<Player_Ammo>().ChangeAmmo(ammoAmount);
            Destroy(gameObject);
        }

    }


}
