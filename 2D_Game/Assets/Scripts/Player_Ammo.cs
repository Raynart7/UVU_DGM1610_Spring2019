using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Ammo : MonoBehaviour{


    public int ammo;
    public Text text;


    public void ChangeAmmo (int newAmmo){
        ammo += newAmmo;
        Display();
        }

    public void Display(){
        text.text = ammo.ToString();
        
    
    }



}