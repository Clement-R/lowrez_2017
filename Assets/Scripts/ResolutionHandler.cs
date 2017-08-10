using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionHandler : MonoBehaviour {
	void Awake () {
        Screen.SetResolution(512, 512, false, 60);
	}
}
