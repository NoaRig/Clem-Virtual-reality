using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswapper : MonoBehaviour
{
    public string SwapToScene;

    public string[] LoadScenes;
    public string[] UnloadScenes;

    [HideInInspector]
    public string MySceneName;

    #region Start
    private void Start()
    {
        MySceneName = gameObject.scene.name;
    }
    #endregion

    #region Object Swapping

    public void SwapObjects(GameObject triggerObject)
    {
        if (MySceneName == SceneManager.GetActiveScene().name)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(SwapToScene));
            UpdateAdjacentScenes();
        }
    }
    #endregion

    private void UpdateAdjacentScenes()
    {
        Debug.Log("Updating adjacent scenes from the " + gameObject.name + "SceneSwapper");
        foreach (string s in LoadScenes)
        {
            SceneManager.LoadSceneAsync(s, LoadSceneMode.Additive);
        }

        foreach (string s in UnloadScenes)
        {
            SceneManager.UnloadSceneAsync(s);
        }
    }
}
