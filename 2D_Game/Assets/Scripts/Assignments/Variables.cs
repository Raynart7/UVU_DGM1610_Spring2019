using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varitables : MonoBehaviour{
   //Variables
    public int number;
    public float speed; 
    public string name;


    // Start is called before the first frame update
    void Start() {
        /*
        This
        is
        a
        multiline
        comment
         */
        // number = 10;
        speed = 0.94f;
        name = "Bob";

        print(name +" is "+number+" years old!"+ speed);

    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(number,0,0);
        
    }
}
