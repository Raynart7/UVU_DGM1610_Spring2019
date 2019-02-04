using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions_2 : MonoBehaviour {
   public string colors;

    void Start(){
    
       Rainbow(colors);
}

    
    void Rainbow(string colorState){

        if(colorState == "Green"){
            print("Adding yellow to blue creates green.");
        }
        else if(colorState == "Purple"){
            print("Adding blue and red together creates pruple.");
        }
        else if(colorState == "Orange"){
            print("Adding red to yellow you'll get orange.");
        }
    }
}
