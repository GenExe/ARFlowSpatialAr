using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutCamScript : MonoBehaviour
{
    public GameObject CamStartPoint;
    public Transform target;

    public void LookAtTarget()
    {
        transform.LookAt(target);
    }

    public void WhyNot()
    {
        StartCoroutine(waiter());
    }

 
    IEnumerator waiter()
    {
        //Wait for 0.2 seconds
        yield return new WaitForSeconds(0.2f);

       
        this.transform.position = CamStartPoint.transform.position;
        this.transform.rotation = CamStartPoint.transform.rotation;
        this.transform.localScale = CamStartPoint.transform.localScale;

    }
}
