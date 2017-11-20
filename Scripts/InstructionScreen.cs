using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionScreen : MonoBehaviour {

    public void NextButtonClick()
    {
        SceneManager.LoadScene("lvl_01");
    }
}
