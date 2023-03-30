using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class correctAnswer : MonoBehaviour
{
    public TMP_Text changeHeader;
    public TMP_Text changeQuestion;
    public Image canvasImage;
    public Button disableYesButton1;
    public Button enableYesButton2;
    public Button disableNoButton1;
    public Button enableNoButton2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextQuestion()
    {
        disableYesButton1.gameObject.SetActive(false);
        enableYesButton2.gameObject.SetActive(true);
        disableNoButton1.gameObject.SetActive(false);
        enableNoButton2.gameObject.SetActive(true);
        changeHeader.text = "Good Choice";
        changeQuestion.text = "This sentence is false:";
        canvasImage.sprite = Resources.Load<Sprite>("emisisblue");
        GameManager.instance.score++;
    }
}
