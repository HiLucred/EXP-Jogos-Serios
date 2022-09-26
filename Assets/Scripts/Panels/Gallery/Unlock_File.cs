using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Unlock_File : MonoBehaviour
{
    [SerializeField] private Text inputText;
    [SerializeField] private InputField inputFieldText;
    [SerializeField] private string password, alternativePassword = "";
    
    public void CheckPassword(GameObject photographys)
    {
        var corretPassword = inputFieldText.text == password 
                             || inputFieldText.text == alternativePassword;
        
        if (corretPassword)
        {
            LeanTween.scale(photographys,  new Vector3(1f, 1f, 1f), 0.3f);
        }
        
        var inputTxt = inputText.text.ToCharArray();
        
        if (inputTxt.Length >= 20)
        {
            inputFieldText.text = "";
        }
    }
}
