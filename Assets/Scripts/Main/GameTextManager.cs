// GameTextManager.cs
// The purpose of the GameTextManager class is to be instanced from and be a
// mechanism/controller for game text
// Created by: RH July 1, 2017
// Modified by: RH July 16, 2017

//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RH.FDRPG {
	
	public class GameTextManager {

		// stores the game text
		public GameText gameText;

		// stores the JSON file text
		public string theText;

		// construct a GameTextManager object
		public GameTextManager () {

			// read in and store the JSON file text as a string
			theText = JSONFileReader.LoadJSONAsResource ("gametext.json");

			// store the game text
			gameText = JsonUtility.FromJson<GameText> (theText);
		
		} // end constructor

	} // end GameTextManager

} // end RH.FDRPG
