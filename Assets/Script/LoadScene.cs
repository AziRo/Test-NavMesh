using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public void Play()
    {
		Time.timeScale = 1;
        StartCoroutine(LoadAsync("1"));
    }
    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator LoadAsync(string name)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(name, LoadSceneMode.Single);
		yield return operation;
	}
}
