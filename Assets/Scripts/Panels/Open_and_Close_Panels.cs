using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Open_and_Close_Panels : MonoBehaviour
{
    [SerializeField] private RectTransform dragRectTransform;

    private void Awake()
    {
        dragRectTransform = GetComponent<RectTransform>();
    }

    public void ClosePanel(GameObject panel)
    {
        LeanTween.scale(panel, new Vector3(0, 0, 0), 0.3f);
    }

    public void OpenPanel(GameObject panel)
    {
        dragRectTransform.SetAsLastSibling();
        LeanTween.scale(panel, new Vector3(1, 1, 1), 0.3f);
    }
}
