﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour

{
    public float delay = 0.1f;
    public string fullText;
    private string currentText;

    // Start is called before the first frame update
    void Start()
        {
        fullText = fullText.Replace("\\n", "\n");
        StartCoroutine(ShowText());
     }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {    
            currentText = fullText.Substring(0, i);
            this.GetComponent<TextMesh>().text = currentText;
            fullText = fullText.Replace("\\n", "\n");
            currentText = currentText.Replace("\\n", "\n");
            yield return new WaitForSeconds(delay);
        }
    }
}
