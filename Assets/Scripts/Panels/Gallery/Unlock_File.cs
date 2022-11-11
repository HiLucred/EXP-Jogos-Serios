using TMPro;
using UnityEngine;

public class Unlock_File : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TMP_InputField  inputFieldText;
    [SerializeField] private string password, alternativePassword = "";
    
    public void CheckPassword(GameObject panel)
    {
        var corretPassword = inputFieldText.text == password 
                             || inputFieldText.text == alternativePassword;
        
        if (corretPassword)
        {
            LeanTween.scale(panel,  new Vector3(1f, 1f, 1f), 0.3f);
        }
        
        var inputTxt = inputText.text.ToCharArray();
        
        if (inputTxt.Length >= 20)
        {
            inputFieldText.text = "";
        }
    }
}
