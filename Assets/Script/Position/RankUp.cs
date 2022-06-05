using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankUp : MonoBehaviour
{

    public GameObject RankUI;
    
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "CarPos")
        {
            RankUI.GetComponent<Text>().text = "1st Place";
            LapComplete.RelativeRank = 1;
        }
    }
}
