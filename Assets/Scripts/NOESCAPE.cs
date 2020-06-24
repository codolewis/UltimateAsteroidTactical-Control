using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOESCAPE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
