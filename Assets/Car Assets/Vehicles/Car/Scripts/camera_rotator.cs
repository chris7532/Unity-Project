using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rator : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
