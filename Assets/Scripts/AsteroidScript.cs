using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    private Transform target;
    public float speed = 1f;
    public GameObject asteroid = null;
    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 10, Random.Range(-25.0f, 25.0f));
        transform.position = Random.insideUnitCircle * 30;
        Instantiate(asteroid, position, Quaternion.identity);
    
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
