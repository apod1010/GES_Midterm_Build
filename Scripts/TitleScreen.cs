using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScreen : MonoBehaviour {
    public void StartButtonClick()
    {
        SceneManager.LoadScene("instructions");
    }

    public void CreditsButtonClick()
    {
        SceneManager.LoadScene("Credits");
    }
}

