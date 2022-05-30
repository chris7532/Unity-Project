using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayCheck : MonoBehaviour
{
    
   public GameObject HalfWay;
   public GameObject FinalWay;

   void OnTriggerEnter() {
       FinalWay.SetActive(true);
       HalfWay.SetActive(false);
       
   }
}
