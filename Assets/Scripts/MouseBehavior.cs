using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour {

    static public Vector2 mousePosition;

    private void Start() {
        Cursor.visible = false;
    }

	void Update () {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.CeilToInt(transform.position.x), Mathf.CeilToInt(transform.position.y));

        mousePosition = transform.position;
    }
}
