//----------------------------------------------------------------------------80
// S1Cube.cs
// The purpose of this script is to be a Component that controls 
// the scene's Cube GameObject as an actor.
// Created by: Randy Habenicht 2/10/2017
// Modified by: Randy Habenicht 2/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RandyHabenicht.FDRPG {

	public class S1Cube : MonoBehaviour, ITransformable<GameObject> {

		// Use this for initialization
		void Start () {

    	}
	
		// Update is called once per frame
		void Update () {
		
		}

		public void Move (float x, float y, float z) {
			gameObject.transform.Translate (x, y, z);
			Debug.Log (name + " has moved.\nPosition: " +
			gameObject.transform.position);
		} // end Move

		// Call the Report method as follows in the Scene script, cube is your
		// sceneObject
		// cube.gameObject.GetComponent<ITransformable<GameObject>> 
		// ().Report ();
		public void Report () {
			Debug.Log (name + " Position: " + gameObject.transform.position);
			Debug.Log (name + " Rotation: " + gameObject.transform.rotation);
			Debug.Log (name + " Scale: " + gameObject.transform.localScale);
		} // End Rotate

		public void Rotate (float x, float y, float z) {
			gameObject.transform.Rotate (x, y, z);
			Debug.Log (name + " has rotated.\nRotation: " +
				       gameObject.transform.rotation);
		} // End Rotate

		public void Scale (float x, float y, float z) {
			// Vector3 tempScale = gameObject.transform.localScale;
			Vector3 scale;
			scale.x = x; // scale positive on X at # units per frome
			scale.y = y; // scale positive on Y at # units per frame
			scale.z = z; // scale positive on Z at # units per frame
			gameObject.transform.localScale = scale; // Update the GameObject scale
			Debug.Log (name + " has scaled.\nScale: " + gameObject.transform.localScale);
		} // End Scale
	} // End S1Cube

} // end RandyHabenicht.FDRPG
