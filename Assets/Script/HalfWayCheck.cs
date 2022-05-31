using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayCheck : MonoBehaviour
{
    
   public GameObject HalfWay;
   public GameObject FinalWay;

   void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "aiCar")
        {
            FinalWay.SetActive(true);
            HalfWay.SetActive(false);
        }
        
       
   }
}
