using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Status1 : MonoBehaviour {
    public float Stamina;
    public float staminaOverTime;

    public Slider StaminaBar;
    

    public float minAmount = 5f;
    public float sprintSpeed = 5f;

    Rigidbody myBody;

    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
    
        StaminaBar.maxValue = Stamina;
        

        updateUI();
    }

    private void Update()
    {
        CalculateValues();
    }

    private void CalculateValues()
    {
       
        if (myBody.velocity.magnitude >= sprintSpeed && myBody.velocity.y == 0)
        {
            Stamina -= staminaOverTime * Time.deltaTime;
          
        }
        else
        {
            Stamina += staminaOverTime * Time.deltaTime;
        }


      

        updateUI();
    }

    private void updateUI()
    {
        
        Stamina = Mathf.Clamp(Stamina, 0, 100f);
      

      
        StaminaBar.value = Stamina;
       
    }

}