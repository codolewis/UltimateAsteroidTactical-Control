using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public Transform tf; // The variable that holds the Transform component
    public GameObject starShip; // The variable that holds the hero component
    public float MoveSpeed = 0; // The variable that holds the speed component
    public int rotationSpeed = 1; // The variable for the degrees we rotate in one frame draw
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();  // tf will get the component Transform
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, rotationSpeed);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -rotationSpeed);
        }

        if (Input.GetKey(KeyCode.W)) // If the W key is held down the sprite will move up until you let off the key
        {
                // Move up every frame draw by adding 1 to the y position
                tf.position = tf.position + (tf.up * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.S)) // If the S key is held down the sprite will move up until you let off the key
        {
                // Move down every frame draw by subtracting 1 to the y position
                tf.position = tf.position - (tf.up * MoveSpeed);
        }
       
        if (Input.GetKeyDown(KeyCode.Escape)) // If the Escape key is pressed
        {
            Application.Quit(); // The application closes
        }
    }
}