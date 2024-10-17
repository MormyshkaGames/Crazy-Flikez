using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    static public int health;
    static public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 10;
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (Movement.faceRight == false)
            {
                Movement.faceRight = true;
            }
            Destroy(gameObject);
        }
    }
  
}
