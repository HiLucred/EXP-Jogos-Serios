using System;
using UnityEngine;
using UnityEngine.UI;

public class Data_and_Time : MonoBehaviour
{
    [SerializeField] private Text dataTime;
    
    private void Update()
    {
        var dt = DateTime.Now;
        dataTime.text = dt.ToString();
    }
}
