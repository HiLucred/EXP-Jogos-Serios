using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gallery : MonoBehaviour
{
    [SerializeField] private Sprite[] photographys;
    [SerializeField] private string[] descriptions;
    [SerializeField] private Image imageField;
    [SerializeField] private TextMeshProUGUI descriptionField;
    private int counter;

    public void Start()
    {
        imageField.sprite = photographys[1];
        descriptionField.text = descriptions[1];
    }

    private void Update()
    {
        if (counter <= 1)
        {
            counter = 1;
        }
    }

    public void NextPhoto()
    {
        if (counter >= photographys.Length - 1)
        {
            counter = 0;
        }
        
        counter++;
        
        imageField.sprite = photographys[counter];
        descriptionField.text = descriptions[counter];
    }

    public void PreviousPhoto()
    {
        if (counter <= 1)
        {
            imageField.sprite = photographys[1];
            return;
        }
        counter--;
        
        imageField.sprite = photographys[counter];
        descriptionField.text = descriptions[counter];
    }
    
}
