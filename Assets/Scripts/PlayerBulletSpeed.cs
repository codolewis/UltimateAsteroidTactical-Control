using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpeed : MonoBehaviour
{
    public float BulletSpeed = 0; // The variable that holds the speed component
    public Transform tf; // The variable that holds the Transform component

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();  // tf will get the component Transform
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.right * BulletSpeed * Time.deltaTime;
          tf.position = tf.position + (tf.up * BulletSpeed);
    }
}
