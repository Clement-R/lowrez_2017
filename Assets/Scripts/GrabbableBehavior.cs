using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableBehavior : MonoBehaviour {

    private Vector2 _startPosition;
    private bool _isDragged = false;
    private SpriteRenderer _sr;

	void Start () {
        _startPosition = transform.position;
        _sr = GetComponent<SpriteRenderer>();
	}

    private void Update() {
        if(_isDragged) {
            transform.position = MouseBehavior.mousePosition;
            _sr.sortingOrder = 1;
        } else {
            transform.position = _startPosition;
            _sr.sortingOrder = 0;
        }
    }

    void OnMouseDown() {
        _isDragged = true;
    }
    void OnMouseUp() {
        _isDragged = false;
    }
}
