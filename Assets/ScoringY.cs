using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringY : MonoBehaviour {

    [SerializeField]
    Transform cylinder;

    [SerializeField]
    Text score;

    float scoreY;

	void Start () {
		
	}

    void Update()
    {
        if (cylinder.position.y > scoreY)
        {
            scoreY = cylinder.position.y;
            score.text = "ScoreY : " + scoreY.ToString();
        }
    }
}
