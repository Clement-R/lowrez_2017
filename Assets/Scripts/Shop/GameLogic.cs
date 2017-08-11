using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    private Stack<Order> _orders = new Stack<Order>();
    private Order _nextOrder = null;

	void Start () {
        // Get day (level) data
        TextAsset json = Resources.Load("day1") as TextAsset;
        Day level = JsonUtility.FromJson<Day>(json.text);

        // Stack customers and send them when a position is available
        foreach (var order in level.orders) {
            _orders.Push(order);
        }

        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[0]));
        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[3]));
        Debug.Log(LaneManager.instance.GetPositionInLane(LaneManager.instance.positions[6]));
        // StartCoroutine("SendCustomers");
    }

    IEnumerator SendCustomers() {
        while(true) {

            // If we doesn't have a waiting order we pick the next one
            if(_nextOrder == null && _orders.Count > 0) {
               _nextOrder = _orders.Pop();
            }

            // Send the customer if it's time of arrival came
            if(Time.time >= _nextOrder.time) {

                // Search a position for the customer, if none is found then we wait
                Transform position = LaneManager.instance.GetAvailablePosition();
                while(position == null) {
                    position = LaneManager.instance.GetAvailablePosition();
                    yield return null;
                }

                // Launch it !
                // set WalkableBehavior : TargetPosition, ExitPosition
                // set SpriteRenderer : OrderInLayer

                _nextOrder = null;
            }

            yield return null;
        }
    }
	
	void Update () {
		
	}
}
