using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private GameObject _map;

	void Awake () {
        _map = GameObject.Find("Canvas/Minimap");
        _map.SetActive(false);
    }
	
	void Update () {
        // Minimap
		if(Input.GetKey(KeyCode.A)) {
            _map.SetActive(true);
        } else {
            _map.SetActive(false);
        }
	}
}
