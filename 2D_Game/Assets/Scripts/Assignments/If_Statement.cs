using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statement : MonoBehaviour{


    public string stopLight;
    public bool isUtahn = true;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        if(stopLight == "Red"){
            //Block off code that is run if the condition is met
            print("STOP!");

            if(isUtahn){
                print("Thank you for stopping.");
            }
    
        else{
            print("Sorry, you are in Utah...");
        }
        }
        
        else if(stopLight == "Yellow"){
            print("Hurry! Floor it!");
        }
        
        else if(stopLight == "Green"){
            print("Brake for no reason.");
        }

        else{
             print("Thank you for preparing to stop.");
            }
    }
}
