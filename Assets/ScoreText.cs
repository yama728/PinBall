using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
	public GameObject scoretext;
	private int score = 0; //スコア計算用変数

	void Start()
	{
		score   = 0;
		SetScore();   //初期スコアを代入して表示
	}
		
	void OnCollisionEnter( Collision collision )
	{

		string Tag  = collision.gameObject.tag;

		if (Tag == "SmallStarTag")
		{
			score += 20;
		} 

		else if (Tag == "LargeStarTag")
		{
			score += 10;
		}

		else if(Tag == "SmallCloudTag")
		{
			score += 5;
		}

		else if(Tag == "LargeCloudTag")
		{
			score += 1;
		}

		SetScore();
	}

	void SetScore()
	{
		this.scoretext = GameObject.Find("ScoreText");

		this.scoretext.GetComponent<Text> ().text = score + "point";
	}

}