using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndSlate : MonoBehaviour
{
    public void ReturnButtonClick()
    {
        SceneManager.LoadScene("title");
    }
}

