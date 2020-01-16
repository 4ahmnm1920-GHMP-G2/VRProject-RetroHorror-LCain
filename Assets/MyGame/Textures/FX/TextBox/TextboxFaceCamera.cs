using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextboxFaceCamera : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.localEulerAngles = new Vector3(-player.transform.localEulerAngles.x + 90 , player.transform.localEulerAngles.y - 180,0);
    }
}
