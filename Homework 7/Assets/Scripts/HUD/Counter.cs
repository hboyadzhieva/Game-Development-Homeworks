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

    public void setCountNumber(int number) {
        if (number >= 100) {
            if (imageOnes == null) imageOnes = Instantiate(prefabDigit,transform);
            if (imageTens == null) imageTens = Instantiate(prefabDigit, transform);
            if (imageHundreds == null) imageHundreds = Instantiate(prefabDigit, transform);
            imageOnes.texture = countTextures[number % 10];
            imageTens.texture = countTextures[(number / 10) % 10];
            imageHundreds.texture = countTextures[number / 100];
        } else if (number >= 10) {
            if (imageOnes == null) imageOnes = Instantiate(prefabDigit, new Vector3(0, 0, 0), Quaternion.identity);
            if (imageTens == null) imageTens = Instantiate(prefabDigit, transform);
            if (imageHundreds != null) Destroy(imageHundreds);
            imageOnes.texture = countTextures[number % 10];
            imageTens.texture = countTextures[number / 10];
        } else if (number >= 0) {
            if (imageOnes == null) imageOnes = Instantiate(prefabDigit, transform);
            if (imageTens != null) Destroy(imageTens);
            if (imageHundreds != null) Destroy(imageHundreds);
            imageOnes.texture = countTextures[number];
        }





    }
}
