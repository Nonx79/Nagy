using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    string mapName;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Map01()
    {
        mapName = "Map01";
    }

    public void Map02()
    {
        mapName = "Map02 1";
    }

    public void ConfirmMapButton()
    {
        LoadScene(mapName);
    }
}