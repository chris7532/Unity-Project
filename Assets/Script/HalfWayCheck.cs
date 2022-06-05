using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayCheck : MonoBehaviour
{
    
   public GameObject HalfWay;
   public GameObject FinalWay;

   void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "PlayerCar")
        {
            FinalWay.SetActive(true);
            HalfWay.SetActive(false);
        }
        
       
   }
}
