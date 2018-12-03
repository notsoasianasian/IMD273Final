using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayHealth : MonoBehaviour {

    public static int health = 100;
    public GameObject player;
    public Slider healthBar;
   // public GameObject Enemy;

	// Use this for initialization
	void Start () {
      //  Enemy.SetActive(true);
        health += 100;
        InvokeRepeating("ReduceHealth", 1, 1);
        
	}

    void ReduceHealth()
    {
        health = health - 0;
        healthBar.value = health;
        if (health <= 0)
            Die();
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Die()
    {
        SceneManager.LoadScene("YouHaveDied");
    }
}
