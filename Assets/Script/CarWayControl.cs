using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWayControl : MonoBehaviour
{
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;

    public GameObject BotCar;
    public IDictionary<int, GameObject> MarkMap;
    public GameObject Tracker;
    public int MarkNumber;      //��s��eTracker

    // Start is called before the first frame update
    void Start()
    {
        MarkMap = new Dictionary<int, GameObject>();
        MarkMap.Add(0, Mark01);
        MarkMap.Add(1, Mark02);
        MarkMap.Add(2, Mark03);
        MarkMap.Add(3, Mark04);
        MarkMap.Add(4, Mark05);
        MarkMap.Add(5, Mark06);
        MarkMap.Add(6, Mark07);
        MarkMap.Add(7, Mark08);
        MarkMap.Add(8, Mark09);
        MarkMap.Add(9, Mark10);
        MarkMap.Add(10, Mark11);
        MarkMap.Add(11, Mark12);
        MarkMap.Add(12, Mark13);
        MarkMap.Add(13, Mark14);
        MarkMap.Add(14, Mark15);
        MarkMap.Add(15, Mark16);
        MarkMap.Add(16, Mark17);
        MarkMap.Add(17, Mark18);
        MarkMap.Add(18, Mark19);
        MarkMap.Add(19, Mark20);
        MarkMap.Add(20, Mark21);
        MarkMap.Add(21, Mark22);
    }

    // Update is called once per frame
    void Update()
    {

        Tracker.transform.position = MarkMap[MarkNumber].transform.position;
        
    }
    IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "aiCar")
        {
            Debug.Log(MarkNumber + 1);
            this.GetComponent<BoxCollider>().enabled = false;
            MarkNumber += 1;
            if (MarkNumber == 22)
            {
                MarkNumber = 0;
            }
            yield return new WaitForSeconds(0.5f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
