using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public bool isTeleporting;

    private void Start()
    {
        Player = GameObject.Find("TeleportGroup");
    }

    public void TeleportMe()
    {
        Player.transform.position = TeleportTo.transform.position;
    }
}
