using System;
using UnityEngine;

public class Home_Icon : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private RectTransform dragRectTransform;
    private bool opened = false;

    public void ToggleMenuPanel()
    {
        if(!opened)
        {
            OpenMenuPanel();
            return;
        }
        
        CloseMenuPanel();
    }
    
    private void OpenMenuPanel() 
    {
        LeanTween.moveY(dragRectTransform, 250f, 0.3f);
        opened = true;
    }

    private void CloseMenuPanel()
    {
        LeanTween.moveY(dragRectTransform, -230f, 0.3f);
        opened = false;
    }
    
}
