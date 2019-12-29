using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeScript : MonoBehaviour
{
    float eyetimer;
    private MeshRenderer myRender;

    void Start()
    {
        myRender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        eyetimer = Random.Range(0.0f, 20.0f);
        if(eyetimer <= 0.5f)
        {
            myRender.enabled = true;
        }
        else if(eyetimer >= 17.5f)
        {
            myRender.enabled = false;
        }
    }
}
