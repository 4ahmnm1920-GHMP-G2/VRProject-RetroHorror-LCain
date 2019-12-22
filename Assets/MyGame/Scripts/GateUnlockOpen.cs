using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlockOpen : MonoBehaviour
{
    public float RotationDirection = 70.0f;

    bool isRunning = false;
    public float waitTime;

    // Look for Key
    void OnTriggerEnter(Collider keyCol)
    {
        if (keyCol.tag == "Key")
        {
            StartCoroutine(WaitCoroutine());
           // isRunning = true;
        }
    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(0.6f);
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            waitTime += Time.deltaTime;

            if (waitTime <= 1)
            {

                Rotate(RotationDirection);

            }
            else
            {
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
