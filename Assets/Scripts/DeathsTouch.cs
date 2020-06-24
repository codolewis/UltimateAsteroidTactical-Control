using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathsTouch : MonoBehaviour {

    public GameObject starShip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject); // Note that we need to destroy the GameObject
                                   //      not just the collider component!
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
