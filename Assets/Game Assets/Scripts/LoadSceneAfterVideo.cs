using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterVideo : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading;
    [SerializeField]
    private string sceneNameLoad;

    private float OnTimerElapsed;

    void Update()
    {
        OnTimerElapsed += Time.deltaTime;

        if (OnTimerElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameLoad);
        }
    }
}
