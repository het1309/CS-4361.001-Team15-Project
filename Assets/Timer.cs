using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
	public TextMeshProUGUI text;
	private float timer;
	[SerializeField] Score score;

    void Update()
	{
		timer += Time.deltaTime;
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer % 60F);
		int milliseconds = Mathf.FloorToInt((timer * 100F) % 100F);
		text.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		if (timer > 0)
		{
			score.score = (int) (Score.MAX_SCORE / timer);
		}
	}

}
