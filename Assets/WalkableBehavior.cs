using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkableBehavior : MonoBehaviour {

    public Transform targetPosition;

	void Start () {
        StartCoroutine(WalkTo(targetPosition.position));
	}

    IEnumerator WalkTo(Vector2 target) {
        while(transform.position.y != targetPosition.position.y) {
            transform.Translate(0, 1, 0);
            yield return new WaitForSeconds(0.1f);
        }

        OnTravelEnd();
    }

    void OnTravelEnd() {

    }
}
