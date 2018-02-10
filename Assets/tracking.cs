using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracking : MonoBehaviour {

    [SerializeField]
    Transform cylinder;

    Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = new Vector3(cylinder.position.x, cylinder.position.y, -10.0f);
        transform.position = pos;
	}
}
