using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlockOpen : MonoBehaviour
{
    public float RotationDirection = 70.0f;

    bool isRunning = false;
    public float waitTime;

    // Look for UpArrow key
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isRunning = true;
        }

        
        if (isRunning)
        {
            waitTime += Time.deltaTime;
            
            if (waitTime <= 1)
            {
                Rotate(RotationDirection);
                
            }
            else {
                isRunning = false;
                waitTime = 0;
            }
        }
        
    }

    //Rotate the Gates
    private void Rotate(float RotationDirection)
    {
        transform.Rotate(0.0f, 0.0f, RotationDirection * Time.deltaTime, Space.Self);
        return;
    }
}
