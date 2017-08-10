using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkableBehavior : MonoBehaviour {

    public Transform targetPosition;
    public Transform exitPosition;

    public float timeBetweenStep = 0.1f;

    IEnumerator WalkTo(Vector2 target) {
        GetComponent<Animator>().SetBool("isWalking", true);

        // Reach target Y position
        while (transform.position.y != target.y) {
            transform.Translate(0, 1, 0);
            yield return new WaitForSeconds(timeBetweenStep);
        }

        // Reach target X position
        while (transform.position.x != target.x) {
            if(transform.position.x > target.x) {
                transform.Translate(-1, 0, 0);
            } else if (transform.position.x < target.x) {
                transform.Translate(1, 0, 0);
            }

            yield return new WaitForSeconds(timeBetweenStep);
        }

        OnTravelEnd();
    }

    public void GoToCounter() {
        StartCoroutine(WalkTo(targetPosition.position));
    }

    public void GoToExit() {
        StartCoroutine(WalkTo(exitPosition.position));
    }

    void OnTravelEnd() {
        GetComponent<Animator>().SetBool("isWalking", false);
    }
}
