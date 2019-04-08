using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour{

    public Hashtable personalDetails = new Hashtable();

    
    void Start(){

        personalDetails.Add("firstname", "Antonio");
        personalDetails.Add("Lastname", "Atwell");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", false);
        personalDetails.Add("age", "16");

        personalDetails.Add("firstname", "Ansel");
        personalDetails.Add("lastname", "Galadiir");
        personalDetails.Add("gender", "male");
        personalDetails.Add("race", "high elf");
        personalDetails.Add("age", "115");

        personalDetails.Add("firstname", "Ida");
        personalDetails.Add("lastname", "unknown");
        personalDetails.Add("gender", "female");
        personalDetails.Add("isMarried", false);
        personalDetails.Add("age", "24");

        personalDetails.Add("name", "Link");
        personalDetails.Add("gender", "male");
        personalDetails.Add("video game", "Breath of the Wild");
        personalDetails.Add("hasMasterSword", true);
        personalDetails.Add("title", "Hero");

        personalDetails.Add("name", "Toothless");
        personalDetails.Add("race", "dragon");
        personalDetails.Add("species", "Nightfury");
        personalDetails.Add("friendly", true);
        personalDetails.Add("rider", "Hiccup");
        
    }
}