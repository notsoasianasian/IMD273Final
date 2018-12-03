using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

    public float curHealth { get; set; }
    public float maxHealth { get; set; }
    int damage = 10;


    public Slider healthbar;

	void Start () {
        maxHealth = 50f;

        curHealth = maxHealth;

        healthbar.value = CalculateHealth();
	}
	
	void Update () {

       // if (Input.GetKeyDown(KeyCode.X))
          //  DealDamage(10);
		
	}

    void TakeDamage(int amount)
    {
        curHealth -= damage;
        healthbar.value = CalculateHealth();

        if (curHealth <= 0)
            Die();


    }

    float CalculateHealth()
    {
        return curHealth / maxHealth;
    }

    void Die()

    {
        curHealth = 0;
        print("Player Dead");
        SceneManager.LoadScene("YouHaveDied");


    }
}
