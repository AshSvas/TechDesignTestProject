using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manager : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        
    }

    public void SceneLoader()
    {
        scene = SceneManager.GetActiveScene();

        if(scene.buildIndex > 0)
            SceneManager.LoadSceneAsync(0);
        else
            SceneManager.LoadSceneAsync(1);
    }
}
