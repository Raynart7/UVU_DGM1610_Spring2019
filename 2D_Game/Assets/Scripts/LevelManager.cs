using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{

    public GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;
    private GameObject player;

    public GameObject deathParticle;
    public GameObject respawnParticle; 

    public float RespawnDelay;

    public int pointPenaltyOnDeath;

    private float gravityScore;


    void Start(){
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");   
    }

    public void RespawnPlayer(){
        StartCoroutine ("RespawnPlayerCo");

    }

    public IEnumerator RespawnPlayerCo(){
        Instantiate(deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
        //player.SetActive(false);
        //player.GetComponent<Renderer> ().enabled = false;

        gravityScore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        
        Debug.Log ("pc Respawn");
        yield return new WaitForSeconds (RespawnDelay);
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityScore;
        player.transform.position = currentCheckPoint.transform.position;

        //player.SetActive(true);
        player.GetComponent<Animator>().SetBool("IsDead", false);
       // player.GetComponent<Renderer> ().enabled = true;
        player.GetComponent<PlayerHealth>().Display();
        Instantiate (respawnParticle, currentCheckPoint.transform, currentCheckPoint);

    }
}
