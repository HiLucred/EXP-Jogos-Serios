using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notification : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI notificationText;
    [SerializeField] private RectTransform notificationBar;

    private void Start()
    {
        OpenNotification("seu dispositivo está em modo de bloqueio. " +
                         "utilize o meio nescessário para voltar ao modo normal");
    }

    public void OpenNotification(string notification)
    {
        notificationText.text = notification;
        LeanTween.moveX(notificationBar, -70f, 0.3f);
    }

    public void CloseNotificaiton()
    {
        LeanTween.moveX(notificationBar, 70f, 0.3f);
    }
}
