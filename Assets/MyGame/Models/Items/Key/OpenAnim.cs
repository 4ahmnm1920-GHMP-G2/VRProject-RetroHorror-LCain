using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnim : MonoBehaviour
{
    //Fetch animator
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called on key enter
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Key")
        {
            m_Animator.SetBool("IsUnlocked", true);
            Destroy(this.gameObject, 3);
        }

    }
}