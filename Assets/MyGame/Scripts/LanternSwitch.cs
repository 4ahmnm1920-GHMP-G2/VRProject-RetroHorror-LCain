using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternSwitch : MonoBehaviour
{
    private Light lanternLight;
    public Material offBodyMat;
    public Material onBodyMat;
    bool toggle;

    void Start()
    {
        lanternLight = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SwitchLanternMatLight();
        }
    }

    private void SwitchLanternMatLight()
    {
        if (toggle == false)
        {
            lanternLight.enabled = true;
            gameObject.GetComponent<Renderer>().material = onBodyMat;
            gameObject.tag = "LanternOn";
            toggle = true;
        }
        else
        {
            lanternLight.enabled = false;
            gameObject.GetComponent<Renderer>().material = offBodyMat;
            gameObject.tag = "LanternOff";
            toggle = false;
        }
    }
}
