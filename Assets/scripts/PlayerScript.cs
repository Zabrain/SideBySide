using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //speed of ship
    public Vector2 speed = new Vector2 (50,50);

    // Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

	
	
	// Update is called once per frame
	void Update () {

        //retrieve axis position
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Movement per direction
        movement = new Vector2(speed.x * inputX, speed.y * inputY);
        
	}

    void FixedUpdate()
    {
        //get component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        //make game object move
        rigidbodyComponent.velocity = movement;
    }
}
