using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SetCameraPosition : MonoBehaviour
{
    public Transform[] pos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.transform.position = pos[0].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.transform.position = pos[1].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.transform.position = pos[2].position;  
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.transform.position = pos[3].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.transform.position = pos[4].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.transform.position = pos[5].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.transform.position = pos[6].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            this.transform.position = pos[7].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.transform.position = pos[8].position;
        }
    }
}
