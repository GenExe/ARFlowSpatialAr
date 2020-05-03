using System;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionController : MonoBehaviour
{
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
        
    }
}
