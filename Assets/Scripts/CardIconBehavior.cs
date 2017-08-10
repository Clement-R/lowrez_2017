using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardIconBehavior : MonoBehaviour {

    public GameObject card;

    private bool _isFocused;
    
	void Update () {
		if(_isFocused) {
            card.SetActive(true);
        } else {
            card.SetActive(false);
        }
	}

    void OnMouseDown() {
        _isFocused = true;
    }
    void OnMouseUp() {
        _isFocused = false;
    }
}
