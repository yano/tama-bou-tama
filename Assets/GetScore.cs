using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    [SerializeField]
    Text srcText;
    [SerializeField]
    Text dstText;

    void OnEnabled()
    {
        dstText.text = srcText.text;
    }


	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
