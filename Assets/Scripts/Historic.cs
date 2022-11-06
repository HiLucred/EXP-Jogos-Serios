using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Historic : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI text2;
    [SerializeField] private TextMeshProUGUI text3;
    [SerializeField] private TextMeshProUGUI text4;

    public void ChangePostItOne(string newText)
    {
        text.text = newText;
    }
    
    public void ChangePostItTwo(string newText)
    {
        text2.text = newText;
    }
    
    public void ChangePostItThree(string newText)
    {
        text3.text = newText;
    }
    
    public void ChangePostItFour(string newText)
    {
        text4.text = newText;
    }
    
    
}
