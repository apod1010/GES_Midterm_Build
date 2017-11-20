using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void BackButtonClick()
    {
        SceneManager.LoadScene("title");
    }
}

