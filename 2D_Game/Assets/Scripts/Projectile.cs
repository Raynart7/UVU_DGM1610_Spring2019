using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour{

    public float speed;
    public float timeOut;
    public GameObject player;
    public GameObject enemyDeath;
    public GameObject projectileParticle;
    public int pointForKill;



    void Start(){

        player = GameObject.Find("Player");
        enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;
        projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;
        
        if(player.transform.localScale.x < 0)
        speed = -speed;
        
        Destroy(gameObject, timeOut);
    }

    void Update(){
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints (pointForKill);
        }
        
        Destroy (gameObject);
    }

    void OnCollisionEnter2D(Collision2D other){

        Instantiate(projectileParticle, transform.position, transform.rotation);

        Destroy (gameObject);
    }
}
