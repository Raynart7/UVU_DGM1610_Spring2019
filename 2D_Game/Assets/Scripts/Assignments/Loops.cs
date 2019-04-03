using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour{

public int bottles = 100;
public bool isRaining = true;
public bool shouldContinue;


    void Start() {

        //for loops
        for(int i=100; i > bottles; i--){
          //  print (i +" bottles of beer on the wall");

          //while loop
          while(bottles <= 100){
            print(bottles +" bottles of beer on the wall");
            bottles ++;
            }
        //do loop
        do
        {
          print ("Hello world");
        }while(shouldContinue == true);

        //Foreach loop
        string [] strings = new string[3];
        strings[0] = "first string";
        strings[1] = "second string";
        strings[2] = "third string";

        foreach(string item in strings)
        {
          print (item);
        }

        } 
    }
        
    

    void Update()
    {
        
    }
}
