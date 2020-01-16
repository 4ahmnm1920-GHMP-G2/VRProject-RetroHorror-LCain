using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugTilt : MonoBehaviour
{
    public GameObject JugObj;
    public ParticleSystem WineObj;
    ParticleSystem.EmissionModule WineEmission;
    public float JugX;
    public float JugY;
    bool isPouring;

    // Start is called before the first frame update
    void Start()
    {
        WineEmission = WineObj.emission;
        WineEmission.rateOverTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        JugX = JugObj.transform.rotation.x;
        JugY = JugObj.transform.rotation.y;

        if (isPouring == true)
        {
            WineEmission.rateOverTime = 120;
        }
        else
        {
            WineEmission.rateOverTime = 0;
        }

        if (transform.up.y < 0f)
        {
            isPouring = true;
        }
        else
        {
            isPouring = false;
        }
    }

}
