using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameENDBUTTON : MonoBehaviour
{
    /// <summary>
    /// ��������. ��ó���⸦ �̿��� ������ �ƴҶ� ����.
    /// </summary>
    public void GameExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
