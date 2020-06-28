using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public int lives = 3;


    void Awake()
    {
        // As long as there is not an instance already set
        if (instance == null)
        {
            instance = this; // Store THIS instance of the class (component) in the instance variable
            DontDestroyOnLoad(gameObject); // Don't delete this object if we load a new scene
        }
        else
        {
            Destroy(this.gameObject); // This will destroy the previous game object ensuring there is only 1 instance at a time
            Debug.Log("Warning: A second game manager was detected and destroyed.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
