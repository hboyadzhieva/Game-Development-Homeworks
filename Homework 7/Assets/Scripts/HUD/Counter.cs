using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField]
    public int MAX = 14;
    
    [SerializeField]
    private Texture[] countTextures;

    public RawImage prefabDigit;
    
    private RawImage imageOnes;
    private RawImage imageTens;
    private RawImage imageHundreds;
    private Transform objTransform;

    private void Start()
    {
        objTransform = this.transform;
        imageOnes = objTransform.Find("DigitOnes").gameObject.GetComponent<RawImage>();
        imageTens = objTransform.Find("DigitTens").gameObject.GetComponent<RawImage>();
        imageHundreds = objTransform.Find("DigitHundreds").gameObject.GetComponent<RawImage>();
    }

    public void setCountNumber(int number) {
        if (number >= 100) {
            imageHundreds.enabled = true; imageTens.enabled = true; imageOnes.enabled = true;
            imageOnes.texture = countTextures[number % 10];
            imageTens.texture = countTextures[(number / 10) % 10];
            imageHundreds.texture = countTextures[number / 100];
        } else if (number >= 10) {
            imageHundreds.enabled = false; imageTens.enabled = true; imageOnes.enabled = true;
            imageOnes.texture = countTextures[number % 10];
            imageTens.texture = countTextures[number / 10];
        } else if (number >= 0) {
            imageHundreds.enabled = false; imageTens.enabled = false; imageOnes.enabled = true;
            imageOnes.texture = countTextures[number];
        }





    }
}
