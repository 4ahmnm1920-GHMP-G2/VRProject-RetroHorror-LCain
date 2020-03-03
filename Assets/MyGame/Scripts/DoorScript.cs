using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerBody;
    public GameObject TeleportTo;
    public bool isTeleporting;
    private Quaternion ThisRot;

    private void Start()
    {
        Player = GameObject.Find("TeleportGroup");
        PlayerBody = Player.transform.GetChild(0).gameObject;
        ThisRot = this.gameObject.transform.rotation;
    }

    public void TeleportMe()
    {
        Player.transform.position = TeleportTo.transform.position;
        PlayerBody.transform.position = TeleportTo.transform.position;
        this.gameObject.transform.rotation = ThisRot;
    }
}
