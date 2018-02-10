using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCreator : MonoBehaviour {

    [SerializeField]
    GameObject treePrefab;

    [SerializeField]
    int probability = 20;

    Vector3 pos;    

	// Use this for initialization
	void Start () {
		
        for (int i =0; i<10000; i++)
        {
            float x = 10 * i;

            int val = UnityEngine.Random.Range(0, 100);

            if (val < probability)
            {
                pos = new Vector3(x, 0, 0);
                GameObject.Instantiate(treePrefab, pos, Quaternion.identity);
            }

        }

	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
