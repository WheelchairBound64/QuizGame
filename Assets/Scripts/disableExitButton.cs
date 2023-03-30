using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class disableExitButton : MonoBehaviour
{
    public Button exitButton;
    public TMP_Text disableText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveEscape()
    {
        exitButton.interactable = false;
        disableText.text = "";
    }
}
