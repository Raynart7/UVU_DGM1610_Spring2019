using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour{
    public static int score;

    private Text ScoreText;

    // Start is called before the first frame update
    void Start(){
        ScoreText = GetComponent<Text>();

        score = 0;
        
    }

    // Update is called once per frame
    void Update(){
        if (score < 0)
            score = 0;

        ScoreText.text = " " + score;
    }

    public static void AddPoints (int pointsToAdd) {
        score += pointsToAdd;
    }






}
