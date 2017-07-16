// JSONFileReader.cs
// The purpose of the JSONFileReader class is to read in text from JSON files
// Created by: RH July 1, 2017
// Modified by: RH July 16, 2017

using UnityEngine;

namespace RH.FDRPG {

	public class JSONFileReader {

		// method to read in JSON files
		public static string LoadJSONAsResource(string path) {

			// remove the .json file extension from the path
			string jsonFilePath = path.Replace (".json", "");

			// read in the JSON file from the Resources folder
			TextAsset loadedJSONFile = Resources.Load<TextAsset>(jsonFilePath);

			// only return the text portion of the JSON file
			return loadedJSONFile.text;

		} // end LoadJSONAsResource

	} // end JSONFileReader

} // end RH.FDRPG
