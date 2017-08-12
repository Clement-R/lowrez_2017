using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdersManager : MonoBehaviour {

    public GameObject[] firstCard;
    public GameObject[] secondCard;
    public GameObject[] thirdCard;
    public GameObject[] fourthCard;

    private bool[] _availableSlots = new bool[4];

    void Start () {
        for (int i = 0; i < _availableSlots.Length; i++) {
            _availableSlots[i] = true;
        }
	}

    public int GetFirstAvailableSlot() {
        for (int i = 0; i < _availableSlots.Length; i++) {
            if(_availableSlots[i]) {
                return i;
            }
        }

        return -1;
    }
}
