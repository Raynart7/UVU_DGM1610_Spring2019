using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour{

    public string suspect;
   
    void Start(){
        MurderMystery(suspect);
    }
    void Update(){
        }




    void MurderMystery (string person){

        switch(person){
            case "Mr. Ketchup":
            case "Mr Radish":
                print("I was in the billiard room smoking a cigar and playing pool with Mr. Radish");
            break;
            case "Ms. Frysauce":
                print("I was talking on the rotory phone with my mother Mrs. Mayo");
            break;
            case "Mrs. Mayo":
                print("I was in the kitchen cleaning up the dishes with the scrubber.");
            break;
            default:
                print("I am not familiar with "+suspect+"!");
            break;

        }




    }






}
