using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardIconBehavior : MonoBehaviour {

    public GameObject card;

    private bool _isFocused;

    void OnMouseDown() {
        card.SetActive(true);
    }
    void OnMouseUp() {
        card.SetActive(false);
    }
}
