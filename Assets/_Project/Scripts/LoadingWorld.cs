using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingWorld : MonoBehaviour {

    public List<int> m_loadLevel = new List<int>();
    public List<int> m_unloadLevel = new List<int>();

    private void OnTriggerEnter(Collider other)
    {
        foreach(int level in m_loadLevel)
        {
            if(!SceneManager.GetSceneByBuildIndex(level).isLoaded)
                SceneManager.LoadSceneAsync(level, LoadSceneMode.Additive);
        }
        foreach(int level in m_unloadLevel)
        {
            if (SceneManager.GetSceneByBuildIndex(level).isLoaded)
                SceneManager.UnloadSceneAsync(level);
        }
    }
}
