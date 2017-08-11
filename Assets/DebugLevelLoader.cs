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



        // Test LaneManager
        /*
        Debug.Log(LaneManager.instance.GetLaneNumber(LaneManager.instance.positions[0]));
        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[0]));

        Debug.Log(LaneManager.instance.GetLaneNumber(LaneManager.instance.positions[1]));
        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[1]));

        Debug.Log(LaneManager.instance.GetLaneNumber(LaneManager.instance.positions[3]));
        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[3]));
        */
    }
}
