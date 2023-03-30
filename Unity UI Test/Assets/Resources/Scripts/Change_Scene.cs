using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    public string sceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
