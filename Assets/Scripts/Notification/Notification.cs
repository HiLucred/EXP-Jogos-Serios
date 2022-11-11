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
        StartCoroutine(nameof(InitialNotification));
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

    private IEnumerator InitialNotification()
    {
        yield return new WaitForSeconds(1f);
        OpenNotification("seu dispositivo está bloqueado." +
                         " para o desbloqueio, é nescessário o uso do terminal.");
    }
}
