using System;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionController : MonoBehaviour
{
    public GameObject NespressoModel;
    public GameObject NespressoMask;

    [Header("Change Model Type for Object Recognition")]
    public bool activateQrCode;
    public List<GameObject> steps;
    public int currentStep = 0;
        
    // Start is called before the first frame update
    void Start()
    {
        DisableAll();
    }

    void DisableAll()
    {
        foreach (var step in steps)
        {
            step.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            DisableAll();
            currentStep = currentStep < steps.Count - 1 ? currentStep + 1 : 0;
            steps[currentStep].SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DisableAll();
            currentStep = currentStep > 0 ? currentStep - 1 : steps.Count - 1;
            steps[currentStep].SetActive(true);
        }

        if (activateQrCode)
        {
            NespressoMask.gameObject.SetActive(false);
            NespressoModel.gameObject.SetActive(true);
        }
        else
        {
            NespressoMask.gameObject.SetActive(true);
            NespressoModel.gameObject.SetActive(false);
        }
    }
}
