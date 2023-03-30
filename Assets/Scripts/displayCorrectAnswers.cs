using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class displayCorrectAnswers : MonoBehaviour
{
    public TMP_Text finalScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Number of correct answers: " + GameManager.instance.score;
    }
}
