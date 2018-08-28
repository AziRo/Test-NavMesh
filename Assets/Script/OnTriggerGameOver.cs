using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;



public class OnTriggerGameOver : MonoBehaviour {
	
	public Text timeText;

	private MouseLook mouseLook;
	private HPUpdater hpUpdater;
	private bool stay;
	private bool gameOver;
	private float time;
	

	void Start()
	{
		time = 0; 
		stay = false;
		gameOver = false;
		hpUpdater = GameObject.Find("FPSController").GetComponent<HPUpdater>();
		mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook;
	}

	void FixedUpdate()
	{
		time += Time.fixedDeltaTime;
		timeText.text = "Time: " + Mathf.RoundToInt(time);
	}

	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.tag == "AI")
		{
			hpUpdater.UpdateHP(-1);
			isGameOver();
		}
	}

	void OnTriggerStay(Collider c)
	{
		
		if(c.gameObject.tag == "AI" && !stay)
		{
			stay = true;
			isGameOver();
			StartCoroutine(delayUpdateHP(1f));
		}
	}

	void isGameOver()
	{
		if(!gameOver && hpUpdater.hp == -1)
		{
			gameOver = true;
			mouseLook.SetCursorLock(false);
			Time.timeScale = 0;
			SceneManager.LoadSceneAsync("Game Over", LoadSceneMode.Additive);
		}
	}

	IEnumerator delayUpdateHP(float seconds)
	{
		yield return new WaitForSeconds(seconds);

		hpUpdater.UpdateHP(-1);
		stay = false;
	}
}
