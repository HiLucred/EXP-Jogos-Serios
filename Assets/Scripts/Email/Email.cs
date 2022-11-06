using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Email : MonoBehaviour
{   
    [Header("E-mail Aside")]
    [SerializeField] private TextMeshProUGUI authorAside;
    [SerializeField] private TextMeshProUGUI subjectAside;
    
    [Header("E-mail Body")]
    [SerializeField] private TextMeshProUGUI titleBody;
    [SerializeField] private TextMeshProUGUI authorBody;
    [SerializeField] private TextMeshProUGUI dateBody;
    [SerializeField] private TextMeshProUGUI contentBody;
    [SerializeField] private TextMeshProUGUI responseBody;
    
    [Header("E-mail Data")]
    [SerializeField] private string author;
    [SerializeField] private string subject;
    [SerializeField] private string title;
    [SerializeField] private string date;
    [SerializeField] private string content;
    [SerializeField] private string response;
    
 
    private void Start()
    {
        authorAside.text = "Autor: " + author;
        subjectAside.text = "Assunto: " + subject;
    }
    
    public void OpenEmail()
    {
        titleBody.text = title;
        contentBody.text = content;
        authorBody.text = author;
        dateBody.text = date;
        responseBody.text = response;
    }
}


