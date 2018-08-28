using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HPUpdater : MonoBehaviour {

	[HideInInspector] public int hp;
	public RawImage[] imageHP;

	void Start()
	{
		hp = imageHP.Length - 1;
	}

	void FixedUpdate()
	{
		for(int i = 0; i <= hp; ++i)
		{
			imageHP[i].rectTransform.Rotate(new Vector3(0, 1, 0), 3);
		}
	}

	public void UpdateHP(int d)
	{
		if(hp == -1) return;

		for(int i = hp; i > hp + d; --i)
		{
			imageHP[i].color = new Color(0f, 0f, 0f);
			imageHP[i].rectTransform.rotation = Quaternion.AngleAxis(0, Vector3.up);
		}

		hp += d;
	}
}
