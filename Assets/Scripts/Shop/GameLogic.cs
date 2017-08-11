using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public Transform[] shopEntries = new Transform[3];
    public Transform[] shopExits;
    public GameObject[] customers;

    private Queue<Order> _orders = new Queue<Order>();
    private Order _nextOrder = null;

	void Start () {
        // Get day (level) data
        TextAsset json = Resources.Load("day1") as TextAsset;
        Day level = JsonUtility.FromJson<Day>(json.text);

        // Stack customers and send them when a position is available
        foreach (var order in level.orders) {
            _orders.Enqueue(order);
        }
        
        StartCoroutine("SendCustomers");
    }

    IEnumerator SendCustomers() {
        while(true) {
            
            // If we doesn't have a waiting order we pick the next one
            if(_nextOrder == null && _orders.Count > 0) {
               _nextOrder = _orders.Dequeue();
            }

            // Send the customer if it's time of arrival came
            if(_nextOrder != null && Time.time >= (float) _nextOrder.time / 1000) {
                // Search a position for the customer, if none is found then we wait
                Transform position = LaneManager.instance.GetAvailablePosition();
                while(position == null) {
                    position = LaneManager.instance.GetAvailablePosition();
                    yield return null;
                }

                // Get enter position
                int lane = LaneManager.instance.GetLaneNumber(position);

                // TODO : instantiate customer given the customerId of the order
                // Instantiate customer and set its spawn position to right shop entry
                GameObject newCustomer = Instantiate(customers[0], shopEntries[lane].position, Quaternion.identity);

                // set WalkableBehavior : TargetPosition, ExitPosition
                WalkableBehavior pathfinder = newCustomer.GetComponent<WalkableBehavior>();
                pathfinder.targetPosition = position;
                // TODO : random on exit
                pathfinder.exitPosition = shopExits[0];

                // set SpriteRenderer : OrderInLayer
                newCustomer.GetComponent<SpriteRenderer>().sortingOrder = LaneManager.instance.GetPositionInLane(position);

                // Launch it !
                pathfinder.GoToCounter();

                _nextOrder = null;
            }

            yield return null;
        }
    }
	
	void Update () {
		
	}
}
