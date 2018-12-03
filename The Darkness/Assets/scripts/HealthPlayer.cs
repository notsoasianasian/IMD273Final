using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HealthPlayer : MonoBehaviour {

    public Slider HealthBar;
    public float Health = 50;
    private float _currentHealth;
 
    void Start()
    {
        _currentHealth = Health;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
    }

    void Die()
    {
        _currentHealth = 0;
        print ("youre dead");
        SceneManager.LoadScene("YouHaveDied");
    }
}
