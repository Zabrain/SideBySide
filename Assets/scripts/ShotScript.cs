using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    //Damage inflicted 
    public int damage = 1;

    //check if projectile damaged ememy or player
    public bool isEnemyShot = false;


	// Use this for initialization
	void Start () {
        //destroy the shot object after 20 second to avoid leaking
        Destroy(gameObject, 20);
	}
	
}
