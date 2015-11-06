using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System;

public class getword : MonoBehaviour
{

	public string FilePath;
	public string FileName;

	public Text _text;

	public string getWord (int difficulty)
	{
		int[] diff = new int[3];

		string line;

		List<string> list = new List<string> ();

		System.IO.StreamReader file = new System.IO.StreamReader (FilePath + "/" + FileName, System.Text.Encoding.UTF8);

		while ((line = file.ReadLine ()) != null) {
			list.Add (line);
		}

		int i = 0;
		line = list [0];

		while (line.Length > 9) {
			i++;
			line = list [i];
		}
		diff [2] = i;

		while (line.Length > 4) {
			i++;
			line = list [i];
		}
		diff [1] = i;

		diff [0] = list.Count;

		System.Random rnd = new System.Random ();

		switch (difficulty) {
		case 1:
			i = rnd.Next (diff [1], diff [0] + 1);
			break;
		case 2:
			i = rnd.Next (diff [2], diff [1] + 1);
			break;
		case 3:
			i = rnd.Next (0, diff [2]);
			break;
		}

		line = list [i];

		file.Close ();

		return line;
	}

	public void changetext ()
	{
		_text.text = getWord (1);
	}
}
