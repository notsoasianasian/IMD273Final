using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


public class PlayHealth : MonoBehaviour {

    public static int health = 100;
    public int maxHealth = 100;
    public GameObject player;
    public Slider healthBar;
    

 //   public Slider staminaSlider;
  //  public int maxStamina;
  //  private int staminaFallRate;
 //   public int staminaFallMult;
 //   private int staminaRegainRate;
 //   public int staminaRegainMult;

 //  private CharacterController charController;
  // private FirstPersonController playerController;

    //public FirstPersonController PlayerController { get => playerController; set => playerController = value; }
   // public CharacterController CharController { get => charController; set => charController = value; }




    // public GameObject Enemy;

    // Use this for initialization
    void Start () {
        //  Enemy.SetActive(true);
        health = maxHealth;
        health += 40;
        InvokeRepeating("ReduceHealth", 1, 1);

   //     staminaSlider.maxValue = maxStamina;
   //     staminaSlider.value = maxStamina;
//
   //     staminaFallRate = 1;
    //    staminaRegainRate = 1;

   //     charController = GetComponent<CharacterController>();
    //    playerController = GetComponent<FirstPersonController>();
        
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

        //StaminaController

     //   if (charController.velocity.magnitude > 0 && Input.GetKey(KeyCode.LeftShift))
      //  {
      //      staminaSlider.value -= Time.deltaTime / staminaFallRate * staminaFallMult;
      //  }

      //  else
      //  {
      //      staminaSlider.value += Time.deltaTime / staminaRegainRate * staminaRegainMult;
       // }

//        if (staminaSlider.value >= maxStamina)
 //       {
  //          staminaSlider.value = maxStamina;
   //     }
//
 ///       else if (staminaSlider.value <= 0)
    //    {
      //      staminaSlider.value = 0;
        //    playerController.m_RunSpeed = playerController.m_WalkSpeed;
       // }
        //else if (staminaSlider.value >= 0)
       // {
       //     playerController.m_RunSpeed = playerController.m_RunSpeedNorm;
        //}


	}

    void Die()
    {
        SceneManager.LoadScene("YouHaveDied");
    }
}
