using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMainMenu : MonoBehaviour
{
    public void ReturnHome()
    {
        GameManager.instance.score = 0;
        SceneManager.LoadScene("Title Screen");
    }
}
