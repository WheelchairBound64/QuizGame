using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class incorrectAnswer : MonoBehaviour
{
    public TMP_Text changeHeader;
    public TMP_Text changeQuestion;
    public Image canvasImage;
    public Button disableYesButton1;
    public Button enableYesButton2;
    public Button disableNoButton1;
    public Button enableNoButton2;
    public Button disableYesButton2;
    public Button disableNoButton2;
    public Button enableYesButton3;
    public Button enableNoButton3;

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
        changeHeader.text = "Wrong";
        changeQuestion.text = "This sentence is false:";
        canvasImage.sprite = Resources.Load<Sprite>("emisisblue");
    }
    public void NextNextQuestion()
    {
        disableYesButton2.gameObject.SetActive(false);
        changeHeader.text = "How can you be so sure?";
        changeQuestion.text = "Last Chance: What is Obama's last name?";
        canvasImage.sprite = Resources.Load<Sprite>("RDT_20210519_012244376441535516044698jpg");
        disableNoButton2.gameObject.SetActive(false);
        enableNoButton3.gameObject.SetActive(true);
        enableYesButton3.gameObject.SetActive(true);
    }
    public void FinalQuestion()
    {
        SceneManager.LoadScene("End Screen");
    }
}
