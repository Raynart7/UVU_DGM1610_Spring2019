using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{

    public GameObject currentCheckPoints;
    private Rigidbody2D pcRigid;
    private GameObject player;

    public GameObject deathParticle;
    public GameObject respawnParticle; 

    public float RespawnDelay;

    public int pointPenaltyOnDeath;

    private float GravityScore;


    void Start(){
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");   
    }

    public void respawnPlayer(){
        StartCoroutine ("RespawnPlayerCo");

    }

    public IEnumerator RespawnPlayerCo(){
        Instantiate(deathParticles, pcRigid.transform.position, pcRigid.transform.rotation);
        player.SetActive(false);
        player.GetComponent<Renderer> ().enabled = false;

        gravityStore = pcRigid.GetComponent<Renderer>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        
        Debug.Log ("pc Respawn");
        yield return new WaitForSeconds (RespawnDelay);
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityScore;
        pc.transform.position = currentCheckPoints.transform.position;

        pc2.SetActive(true);
        pc.GetComponent<Renderer> ().enabled = true;
        Instantiate (respawnParticle, currentCheckPoint.transform, currentCheckPoint);

    }
}
