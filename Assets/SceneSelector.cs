using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSelector : MonoBehaviour {

    public Transform shopScene;
    public Transform cookScene;
    public Transform fillingScene;
    public Transform toppingScene;

    void SetPosition(Vector3 newPosition) {
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }

    public void GoToShop() {
        SetPosition(shopScene.position);
    }

    public void GoToCook() {
        SetPosition(cookScene.position);
    }

    public void GoToFilling() {
        SetPosition(fillingScene.position);
    }

    public void GoToTopping() {
        SetPosition(toppingScene.position);
    }
}
