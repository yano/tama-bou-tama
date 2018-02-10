using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweet : MonoBehaviour {

    [SerializeField]
    Text scoreX;

    [SerializeField]
    Text scoreY;

    public void DoTweet()
    {
        naichilab.UnityRoomTweet.Tweet("tamaboutama", "たまぼうたまで Score X=" + scoreX.text + ", Y=" + scoreY.text + " 獲得しました！" , "たまぼうたま", "unity1week");
    }
}
