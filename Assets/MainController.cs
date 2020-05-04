using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject ModelTarget;
    public GameObject ImageTarget;
    public bool setImageTargetActive = true;

    void Start()
    {
        if (setImageTargetActive)
        {
            ModelTarget.SetActive(false);
            ImageTarget.SetActive(true);
        }
        else
        {
            ImageTarget.SetActive(false);
            ModelTarget.SetActive(true);
        }
    }

}
