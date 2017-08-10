using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverableBehavior : MonoBehaviour {
    // Update is called once per frame
    void OnMouseEnter() {
        GetComponent<SpriteOutline>().outlineSize = 1;
    }

    private void OnMouseExit() {
        GetComponent<SpriteOutline>().outlineSize = 0;
    }
}
