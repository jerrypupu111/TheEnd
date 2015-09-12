﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TypeWriter : MonoBehaviour {

	public Text text;
	string content;	
	public bool isPlaying = false;
	static float letterPause = 0.1f;
	private IEnumerator coroutine;
	public void Play(string text)
	{
		this.content = text;
		coroutine = DialogueAsync();
		StartCoroutine(coroutine);
	}
	public void Skip()
	{
		StopCoroutine(coroutine);
		text.text += content.Substring(letterIndex);
		isPlaying = false;
	}
	
	int letterIndex;
	IEnumerator DialogueAsync()
	{
		text.text = "";
		letterIndex = 0;
		isPlaying = true;
		foreach(char letter in content)
		{
			text.text += letter;
			letterIndex++;
			yield return new WaitForSeconds(letterPause);
		}
		isPlaying = false;
	}
}