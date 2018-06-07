using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    //Object Speed
    public Vector2 speed = new Vector2(5, 5);


    //moving direction
    public Vector2 direction = new Vector2(-1, 0);

    // Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;


    // Update is called once per frame
    void Update()
    {

        //Movement per direction
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);

    }

    void FixedUpdate()
    {
        //get component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        //make game object move
        rigidbodyComponent.velocity = movement;
    }

}
