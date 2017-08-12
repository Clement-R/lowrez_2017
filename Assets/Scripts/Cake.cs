using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CakeData {
    public int layer1;
    public int filling1;
    public int layer2;
    public int filling2;
    public int layer3;
    public int topping;
}

public class Cake : MonoBehaviour {

    private CakeData _data = null;

    void Start () {
        TextAsset json = Resources.Load("cake1") as TextAsset;
       _data = JsonUtility.FromJson<CakeData>(json.text);
	}

    void CreateCard() {

    }
}
