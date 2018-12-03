using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CabinEnter : MonoBehaviour {

    public GameObject LevelExit;

    void onTriggerEnter(Collider other) {

        SceneManager.LoadScene("YouHaveDied");
        print("you won");
      
    }

}
