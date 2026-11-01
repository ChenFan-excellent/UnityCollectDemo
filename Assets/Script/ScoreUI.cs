using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour {

    public Text score;
    public int totallynumber = 3;
    public Image image;
    public Text Game_over;
	// Use this for initialization
	void Start () {
        image.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore(int count)
    {
        if (count >= totallynumber)
        {
            Debug.Log("收集完成！");
            score.text = "收集完成！";
        }
        else
        {
            score.text = "已收集：" + count;
            Debug.LogFormat("已收集{0}/{1}", count, totallynumber);
        }
    }

    public void ShowGameOver(string message = "Game Over")
    {
        Game_over.text = message;
        Time.timeScale = 0f;
        image.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
