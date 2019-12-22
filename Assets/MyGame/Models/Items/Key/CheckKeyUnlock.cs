using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKeyUnlock : MonoBehaviour
{
    //Fetch animator
    Animator m_Animator;
    //Decide if lock should open
    public bool m_open;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            m_open = true;
        else m_open = false;

        if (m_open == false)
            m_Animator.SetBool("IsUnlocked", false);

        if (m_open == true)
            m_Animator.SetBool("IsUnlocked", true);
    }
}
