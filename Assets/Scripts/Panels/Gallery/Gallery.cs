using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gallery : MonoBehaviour
{
    [SerializeField] private Sprite[] photographys;
    [SerializeField] private Image imageField;
    private int counter;

    public void NextPhoto()
    {
        if (counter >= photographys.Length - 1)
        {
            counter = 0;
        }
        counter++;
        
        imageField.sprite = photographys[counter];
    }

    public void PreviousPhoto()
    {
        if (counter <= 0)
        {
            imageField.sprite = photographys[1];
            return;
        }
        counter--;
        
        imageField.sprite = photographys[counter];
    }
    
}
