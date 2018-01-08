using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingAwake : MonoBehaviour {

    public List<int> m_listSceneOnAwake = new List<int>();

    private void Awake()
    {
        foreach(int scene in m_listSceneOnAwake)
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
    }
}
