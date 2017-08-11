using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneManager : MonoBehaviour {

    public static LaneManager instance = null;
    public Transform[] positions = new Transform[9];

    private bool[] _positionsState = new bool[9];

    void Awake() {
        // Singleton pattern
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
    }

    void Start () {
        for (int i = 0; i < 9; i++) {
            _positionsState[i] = true;
        }
	}

    public Transform GetAvailablePosition() {
        Transform availablePosition = null;
        int id = -1;

        // Search for an available position
        for (int i = 0; i < _positionsState.Length; i++) {
            if (_positionsState[i] == true) {
                id = i;
                break;
            }
        }

        // Return position or null
        if (id != -1) {
            availablePosition = positions[id];
            _positionsState[id] = false;
        }
        return availablePosition;
    }

    public void FreePosition(Transform position) {
        for (int i = 0; i < positions.Length; i++) {
            if (positions[i] == position) {
                _positionsState[i] = true;
            }
        }
    }

    public int GetLaneNumber(Transform position) {
        for (int i = 0; i < positions.Length; i++) {
            if (positions[i] == position) {
                return (i / 3);
            }
        }

        return -1;
    }

    public int GetPositionInLane(Transform position) {

        for (int i = 0; i < positions.Length; i++) {
            if(positions[i] == position) {
                return ((i % 3) + 1);
            }
        }

        return -1;
    }
}
