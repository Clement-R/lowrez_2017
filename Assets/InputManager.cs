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
        
		if(Input.GetMouseButton(1)) {
            GameObject.Find("Canvas").GetComponent<RectTransform>().position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
            _map.SetActive(true);
        } else {
            _map.SetActive(false);
        }
	}
}
