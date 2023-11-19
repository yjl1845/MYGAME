using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class NextmissionButton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Stage 2");
    }
}
