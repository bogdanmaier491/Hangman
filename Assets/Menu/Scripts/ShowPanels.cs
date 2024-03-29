﻿using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour
{

	public GameObject optionsPanel;
	//Store a reference to the Game Object OptionsPanel
	public GameObject optionsTint;
	//Store a reference to the Game Object OptionsTint
	public GameObject menuPanel;
	//Store a reference to the Game Object MenuPanel
	public GameObject pausePanel;
	//Store a reference to the Game Object PausePanel



	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel ()
	{
		optionsPanel.SetActive (true);
		optionsTint.SetActive (true);
		FadeIn ();
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel ()
	{
		optionsTint.SetActive (false);
		FadeOut ();
	}

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu ()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu ()
	{
		menuPanel.SetActive (false);
	}
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel ()
	{
		pausePanel.SetActive (true);
		optionsTint.SetActive (true);
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel ()
	{
		pausePanel.SetActive (false);
		optionsTint.SetActive (false);

	}

	private void FadeIn ()
	{
		optionsPanel.GetComponent<CanvasGroup> ().alpha += Time.deltaTime;

		if (optionsPanel.GetComponent<CanvasGroup> ().alpha < 1)
			Invoke ("FadeIn", 0.001f);
	}

	private void FadeOut ()
	{
		optionsPanel.GetComponent<CanvasGroup> ().alpha -= Time.deltaTime;

		if (optionsPanel.GetComponent<CanvasGroup> ().alpha > 0)
			Invoke ("FadeOut", 0.001f);
		else
			optionsPanel.SetActive (false);
	}

	private void Update ()
	{
	}
}
