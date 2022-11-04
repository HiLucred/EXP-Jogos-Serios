using System;
using UnityEngine;

public class Home_Icon : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private RectTransform dragRectTransform;
    private bool on = false;

    public void ToggleMenuPanel()
    {
        on = !on;
        
        if(on)
        {
            OpenMenuPanel();
            return;
        }
        
        CloseMenuPanel();
    }
    
    private void OpenMenuPanel() 
    {
        LeanTween.moveY(menuPanel, 0.0001f, 0.3f);
    }

    private void CloseMenuPanel()
    {
        LeanTween.moveY(menuPanel, -0.0001f, 0.3f);
    }
    
}
