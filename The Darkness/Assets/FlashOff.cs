using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashOff : MonoBehaviour {

    public Light Light1;
    public Light Light2;
    public Light Light3;
    public AudioSource Click;
    private bool isActive;

    void Start()
    {
        isActive = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isActive == false)
            {
                Light1.enabled = true;
                Light2.enabled = true;
                Light3.enabled = true;
                isActive = true;
                Click.Play();
            }
            else if (isActive == true)
            {
                Light1.enabled = false;
                Light2.enabled = false;
                Light3.enabled = false;
                isActive = false;
                Click.Play();

            }

        }
    }
}
