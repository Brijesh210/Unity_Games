using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Light sun;
    public Light spot_light;


    void Start()
    {
        spot_light.enabled = false;
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("W was pressed");
            sun.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("U was pressed");
            sun.enabled = true;
        }


    }

}
