//----------------------------------------------------------------------------80
// S1Directionalight.cs
// The purpose of this script is to be a Component that controls 
// the scene's DirectionalLight GameObject as an actor.
// Created by: Randy Habenicht 2/10/2017
// Modified by: Randy Habenicht 2/10/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RandyHabenicht.FDRPG {

	public class S1DirectionalLight : MonoBehaviour, ITransformable<GameObject> {

		// Use this for initialization
		void Start () {
		
		} // End Start
	
		// Update is called once per frame
		void Update () {
		
		} // End Update

		public void Move (float x, float y, float z) {
			Debug.Log ("Move " + "stuff!");
		} // End Move

		public void Report() {
			Debug.Log (name + " Position: " + gameObject.transform.position);
			Debug.Log (name + " Rotation: " + gameObject.transform.rotation);
			Debug.Log (name + " Scale: " + gameObject.transform.localScale);
		} // End Report

		public void Rotate(float x, float y, float z) {
			gameObject.transform.Rotate (x, y, z);
			Debug.Log (name + " has rotated.");
			Debug.Log (name + " Rotation: " + gameObject.transform.rotation);
		} // End Rotate

		public void Scale (float x, float y, float z) {
			//Vector3 tempScale = gameObject.transform.localScale;
			Vector3 scale;
			scale.x = x; // scale positive on X at # units per frome
			scale.y = y; // scale positive on Y at # units per frame
			scale.z = z; // scale positive on Z at # units per frome
			gameObject.transform.localScale = scale; // Update the GameObject scale
			Debug.Log (name + " has scaled.");
			Debug.Log (name + " Scale: " + gameObject.transform.localScale);
		} // End Scale
			
	} // End S1DirectionalLight

} // End RandyHabenicht.FDRPG
