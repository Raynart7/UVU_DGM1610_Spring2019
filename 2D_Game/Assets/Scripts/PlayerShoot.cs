using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour{

    public Transform firePoint;
    public GameObject projectile;



    void Update(){
        if(Input.GetKeyDown(KeyCode.RightControl) && GetComponent<Player_Ammo>().ammo > 0){
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            GetComponent<Player_Ammo>().ChangeAmmo(-1);
        }
    }
}
