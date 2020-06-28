using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletDamage : MonoBehaviour
{

    public GameObject enemyShip = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false); // this destroys the enemy
            Destroy(gameObject); // this destroys the bullet
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
