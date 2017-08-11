using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLevelLoader : MonoBehaviour {
	void Start () {
        // Find json file
        var json = Resources.Load("day1") as TextAsset;
        
        // Read json file
        var level = JsonUtility.FromJson<Day>(json.text);
        
        // Display orders
        // Debug.Log(level.orders[0].cakeId);
    }
}
