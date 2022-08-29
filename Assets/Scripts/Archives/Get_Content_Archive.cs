using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_Content_Archive : MonoBehaviour
{
    [SerializeField] private Text directoryName;
    [SerializeField] private Text archiveContent;

    public void ChangeDirectoryName(string directory)
    {
        directoryName.text = "C://";
        directoryName.text += directory;
    }
    
    public void ChangeContent(string content)
    {
        archiveContent.text = content;
    }
}
