using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour{


    public int health;
    public GameObject healthImage1;
    public GameObject healthImage2;
    public GameObject healthImage3;


    public void ChangeHealth (int newHealth){
        health += newHealth;
        
        }

    public void Display(){
        switch(health){
            case 3:
                healthImage1.SetActive(true);
                healthImage2.SetActive(true);
                healthImage3.SetActive(true);
                break;
            case 2:
                healthImage1.SetActive(true);
                healthImage2.SetActive(true);
                healthImage3.SetActive(false);
                break;
            case 1:
                healthImage1.SetActive(true);
                healthImage2.SetActive(false);
                healthImage3.SetActive(false);
                break;
            case 0:
                healthImage1.SetActive(false);
                healthImage2.SetActive(false);
                healthImage3.SetActive(false);
                print("YOU DIED");
                break;



        }
    }



    
}
