using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    //total hitpoints
    public int hp = 1;

    //Enemy or player?
    public bool isEnemy = true;

    //damages the object (Enemy or Player) and check if it should be destroyed
    public void Damage(int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            //dead 
            Destroy(gameObject);
        }
    }

    //this happens when an ontrigerenter occurs
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Check if the collider is a shot
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();

        if (shot != null)
        {
            //Avoid losing life if shot is from origin object
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);

                Destroy(shot.gameObject);
            }
        }
    }
}
