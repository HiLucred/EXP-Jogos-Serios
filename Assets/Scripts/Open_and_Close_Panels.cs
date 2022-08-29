using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_and_Close_Panels : MonoBehaviour
{
    public void ClosePanel(GameObject panel)
    {
        LeanTween.scale(panel, new Vector3(0, 0, 0), 0.3f);
    }

    public void OpenPanel(GameObject panel)
    {
        LeanTween.scale(panel, new Vector3(1, 1, 1), 0.3f);
    }
}
