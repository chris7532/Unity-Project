using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankDown : MonoBehaviour
{
    public GameObject RankUI;
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CarPos")
        {
            RankUI.GetComponent<Text>().text = "2nd Place";
            LapComplete.RelativeRank = 2;
        }
    }
}
