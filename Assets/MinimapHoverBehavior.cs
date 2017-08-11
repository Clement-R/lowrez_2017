using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapHoverBehavior : MonoBehaviour {

    private RawImage _image;
    private Color _color;

    private void Awake() {
        _image = GetComponent<RawImage>();
        _color = _image.color;
    }

    public void OnMouseExit() {
        _image.color = _color;
    }

    public void OnMouseEnter() {
        _image.color = new Color(_color.r, _color.g, _color.b, 1);
    }
}
