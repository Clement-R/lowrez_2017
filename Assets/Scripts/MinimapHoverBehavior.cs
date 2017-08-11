using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapHoverBehavior : MonoBehaviour {

    public enum Location {
        Shop,
        Cooking,
        Filling,
        Topping
    }

    public Location location;

    private Image _image;
    private Color _color;
    private SceneSelector _sceneManager;

    private void Awake() {
        _image = GetComponent<Image>();
        _color = _image.color;
        _sceneManager = Camera.main.GetComponent<SceneSelector>();
    }

    public void OnMouseDown() {
        switch(location) {
            case Location.Shop:
                _sceneManager.GoToShop();
                break;
            case Location.Cooking:
                _sceneManager.GoToCook();
                break;
            case Location.Filling:
                _sceneManager.GoToFilling();
                break;
            case Location.Topping:
                _sceneManager.GoToTopping();
                break;
        }
    }

    public void OnMouseExit() {
        _image.color = _color;
    }

    public void OnMouseEnter() {
        _image.color = new Color(_color.r, _color.g, _color.b, 1);
    }

    public void OnDisable() {
        _image.color = _color;
    }
}
