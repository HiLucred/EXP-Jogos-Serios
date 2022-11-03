using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_and_Destroy_Panels : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    
    private void Start()
    {
        
    }

    
    private void Update()
    {
        
    }

    public void OpenPanel()
    {
        Instantiate(panel, new Vector3(-50, -50, 0), Quaternion.identity);
    }

    public void ClosePanel()
    {
        Destroy(panel);
    }
}
