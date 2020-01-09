using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBurnScript : MonoBehaviour
{
    public bool isRunning = false;
    public GameObject FireChild;

    // Look for Key .DOESNT WORK
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "LanternOn")
        {
            isRunning = true;
        }

    }

    //look for isRunning bool, activate fire, call WebDestroy .WORKS
    void Update()
    {
        if (isRunning)
        {
            Debug.Log("Fire started!");
            isRunning = true;
            FireChild.SetActive(true);
            WebDestroy();
        }
        else
        {
            isRunning = false;
            FireChild.SetActive(false);
        }
    }

    //Destroy self
    private void WebDestroy()
    {
        Debug.Log("Destroying web in 3");
        Destroy(gameObject, 3);
    }

}
