using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TMP_InputField  inputFieldText;
    [SerializeField] private string password = "";
    [SerializeField] private GameObject emailIcon;
    [SerializeField] private GameObject internetIcon;
    [SerializeField] private GameObject mysteryousIcon;
    [SerializeField] private GameObject galleryIcon;
    [SerializeField] private GameObject archivesIcon;
    [SerializeField] private GameObject musicPlayerIcon;

    [SerializeField] private GameObject panel;

    public void CheckPassword()
    {
        if (inputFieldText.text != password) return;
        Invoke(nameof(OpenPanel), 0.8f);
        Debug.Log("Foi :)");
    }

    private void OpenPanel()
    {
        LeanTween.scale(panel,  new Vector3(1f, 1f, 1f), 0.3f);
        inputFieldText.text = "sucesso";
        emailIcon.SetActive(true);
        mysteryousIcon.SetActive(true);
        internetIcon.SetActive(true);
        galleryIcon.SetActive(true);
        archivesIcon.SetActive(true);
        musicPlayerIcon.SetActive(true);
    }
    
}
