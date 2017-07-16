// GameText.cs
// The purpose of the GameText class is to be instanced from, contain and match the serialized
// game text from a JSON file
// Created by: RH July 1, 2017
// Modified by: RH July 16, 2017

using UnityEngine;

namespace RH.FDRPG {

	// the class is to be serializable in order to match with the JSON file keys
	[System.Serializable]
	public class GameText {

		// stores the main menu text
		public string mainMenu;

	} // end GameText

} // end RH.FDRPG
