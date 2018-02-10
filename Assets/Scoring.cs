using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    [SerializeField]
    Transform cylinder;

    [SerializeField]
    Text score;

	void Start () {
		
	}

    void Update()
    {
        score.text = "ScoreX : " + cylinder.position.x.ToString();
    }
}
