using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteAfterSomeSec : MonoBehaviour {

    [SerializeField]
    Text someText;

    [SerializeField]
    float time = 10.0f;

    float timeTmp = 0.0f;

    //// Use this for initialization
    //void Start () {
    //}

    // Update is called once per frame
    void Update()
    {
        timeTmp += Time.deltaTime;

        if (!string.IsNullOrEmpty(someText.text))
        {
            if (timeTmp > time)
            {
                someText.text = "";
            }
        }
    }
}
