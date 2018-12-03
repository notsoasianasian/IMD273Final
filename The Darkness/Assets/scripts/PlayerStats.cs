using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static float stamina;
    public float maxStamina;
    public float hunger;
    public float maxHunger;
    public float thirst;
    public float maxThirst;
    public float coldness;
    public float maxCold;

    private bool running;
    private bool triggeringHeatSource;

    
    void Start ()
    {
        stamina = maxStamina;
		
	}
	
	
	void Update ()
    {
        print("hunger");
        if(hunger < maxHunger)
        {
           hunger += 0.5f * Time.deltaTime;
        }
        if (thirst < maxThirst)
        {
            thirst += 0.5f *Time.deltaTime;
        }
        if (hunger >= maxHunger || thirst>= maxThirst)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && stamina > 0)
        {
            stamina -= 10 * Time.deltaTime;
        }
        if (stamina <= 0)
        {
            print("stamina = 0 cant sprint wait");
        }
        if (triggeringHeatSource && coldness > 0)
        {
            coldness -= 1 * Time.deltaTime;
        }
        if (triggeringHeatSource == false)
        {
            coldness += 1 * Time.deltaTime;
        }
        

	}

    void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Water")
        {
            hunger = hunger - 50;
            Destroy(other.gameObject);
        }

        if (other.tag == "Water")
        {
            thirst = thirst - 25;
            Destroy(other.gameObject);
        }

        if (other.tag == "HeatSource")
        {
            triggeringHeatSource = true;

        }
    }

    void OnTiggerExit(Collider other)
    {

        if (other.tag == "HeatSource")
        {
            triggeringHeatSource = false;

        }

    }

    void Die()
    {
        print("dead");
    }
}


