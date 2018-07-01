using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highscoreText;

	public float scoreCount;
	public float highscoreCount;

	public float pointsperSecond;

	public bool scoreIncreasing;        



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreIncreasing) {

			scoreCount += pointsperSecond * Time.deltaTime;
		}
		
		if (scoreCount > highscoreCount) {
			highscoreCount = scoreCount;
		}


		scoreText.text = "Score : " +  Mathf.Round(scoreCount);
		highscoreText.text = "High Score : " + Mathf.Round(highscoreCount);

		
	}
		
	}

