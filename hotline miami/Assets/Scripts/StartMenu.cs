﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;


	void Start () 
	{
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;
	}

	public void NoPress ()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}
	
	public void ExitPress ()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void StartLevel ()
	{
		SceneManager.LoadScene("hotline");
		//Application.LoadLevel (1);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
