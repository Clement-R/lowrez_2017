using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCameraMove : MonoBehaviour {

    SceneSelector sceneManager;

	void Start () {
        sceneManager = Camera.main.GetComponent<SceneSelector>();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)) {
            sceneManager.GoToShop();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            sceneManager.GoToCook();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            sceneManager.GoToFilling();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            sceneManager.GoToTopping();
        }
    }
}
