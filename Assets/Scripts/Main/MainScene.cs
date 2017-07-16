// MainScene.cs
// The purpose of the MainScene script is for it to execute from the MainDirector and be
// the main script for the FDRPG and only script to inherit from the MonoBehavior class
// Created by: RH July 1, 2017
// Modified by: RH July 16, 2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RH.FDRPG;

	public class MainScene : MonoBehaviour {

		// MainScene sceneObjects manually assigned in Inspector for referencing
		public GameObject MainDirector;
	    public GameObject MainCamera;
		public GameObject MainCanvas;
		public GameObject ScreenText;

		void Awake() {

			// create the GameTextManager
			GameTextManager theGameText = new GameTextManager ();

			// get a reference to ScreenText's text component 
			Text getText = ScreenText.GetComponentInChildren<Text> ();

			// set ScreenText's text component to the main menu text
			getText.text = theGameText.gameText.mainMenu;

		} // end Awake

		// Use this for initialization
		void Start () {

			// do some console debug output for now
			Debug.Log (MainCanvas.gameObject.name);
			Debug.Log (MainCanvas.hideFlags);
			Debug.Log (MainCanvas.GetInstanceID ());
			Debug.Log (MainCanvas.ToString ());
			Debug.Log (MainCanvas.gameObject);
			Debug.Log (MainCanvas.tag);
			Debug.Log (MainCanvas.transform);

		} // end Start

		// Update is called once per frame
		void Update () {
			
		} // end Update

		// MainDirector's ability to move GameObjects
		public void Move (GameObject sceneObject, float x, float y, float z) {
			sceneObject.transform.Translate (x, y, z);
			Debug.Log (name + " has moved.\nPosition: " +
			sceneObject.transform.position);
		} // end Move

		// MainDirectors's ability to rotate GameObjects
		public void Rotate (GameObject sceneObject, float x, float y, float z){
			sceneObject.transform.Rotate (x, y, z);
			Debug.Log (name + " has rotated.\nRotation: " +
			sceneObject.transform.rotation);
		} // end Rotate

		// MainDirector's ability to scale GameObjects
		public void Scale (GameObject sceneObject, float x, float y, float z) {
			Vector3 scale;
			scale.x = x; // scale positive on X at # units per frome
			scale.y = y; // scale positive on Y at # units per frame
			scale.z = z; // scale positive on Z at # units per frame
			sceneObject.transform.localScale = scale; // Update the GameObject scale
			Debug.Log (name + " has scaled.\nScale: " + sceneObject.transform.localScale);
		} // end Scale

		// MainDirector's ability to get status reports on GameObjects in the console
		// Call the Report method as follows in the Scene script, cube is your
		// sceneObject
		// cube.gameObject.GetComponent<ITransformable<GameObject>> ().Report ();
		public static void Report (GameObject sceneObject, float x, float y, float z) {
			Debug.Log (sceneObject.name + " Position: " + sceneObject.transform.position);
			Debug.Log (sceneObject.name + " Rotation: " + sceneObject.transform.rotation);
			Debug.Log (sceneObject.name + " Scale: " + sceneObject.transform.localScale);
		} // end Report

	} // end MainScene
