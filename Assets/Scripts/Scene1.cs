//----------------------------------------------------------------------------80
// Scene1.cs
// The purpose of this script is to be a Component that mimics an actual movie
// script for the Scene Director to use to direct the scene's GameObjects as
// actors.
// Created by: Randy Habenicht 2/8/2017
// Modified by: Randy Habenicht 2/8/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RandyHabenicht.FDRPG {
    
    public class Scene1 : MonoBehaviour {
		
        // Scene1 sceneObjects manually assigned in Inspector
        public GameObject mainCamera;
        public GameObject directionalLight;
        public GameObject cube;
        // Use this for initialization
        void Start () {
            // Inherited members of the Object Class
            Debug.Log ("Scene1 Director and Scene1 script ready.");
            Debug.Log (gameObject.name);
            Debug.Log (gameObject.hideFlags);
			if (gameObject.transform) {
				Debug.Log ("Yes, " + gameObject.name + 
					       "has a transform Component.");
			} // end if
			if (this) {
				Debug.Log ("Yes, " + gameObject.name + 
					       "has a Scene1 Component.");
			} // end if
			if (this) {
				Debug.Log ("Yup, " + ToString () );
			} // end if
			Debug.Log (gameObject);

			// Inherited members of the Component Class
            Debug.Log ("The GameObject that this script Component (" + 
				       this.GetType() + ") is attached to is: " + 
				       gameObject.name);

			// Inherited members of the Behavior Class
			Debug.Log("what");

			// Inherited members of the MonoBehaviour Class
			print ("What's up doc?");

			// Move (cube, 5f * Time.deltaTime, 0f, 0f);
			// Rotate (cube, 0f, 0f, 5f * Time.deltaTime);
			// Scale (cube, 2f * Time.deltaTime, 2f * Time.deltaTime, 
			// 2f * Time.deltaTime);

		} // End Start

		// Update is called once per frame
		void Update () {
			Move (cube, 1f * Time.deltaTime, 0f, 0f);
			Rotate (cube, 0f, 0f, 1f * Time.deltaTime);
			Scale (cube, 1f * Time.deltaTime, 1f * Time.deltaTime, 1f * Time.deltaTime);
		} // End Update

		public void Move (GameObject sceneObject, float x, float y, float z) {
			ITransformable<GameObject> transformer;
			transformer = 
			sceneObject.gameObject.GetComponent<ITransformable<GameObject>> ();
			transformer.Move (x, y, z);
		} // End Scale

		public void Rotate (GameObject sceneObject, float x, float y, float z){
			ITransformable<GameObject> transformer;
			transformer =
			sceneObject.gameObject.GetComponent<ITransformable<GameObject>> ();
			transformer.Rotate (x, y, z);
		} // End Rotate

		public void Scale (GameObject sceneObject, float x, float y, float z) {
			ITransformable<GameObject> transformer;
			transformer =
			sceneObject.gameObject.GetComponent<ITransformable<GameObject>> ();
			transformer.Scale (x, y, z);
		} // End Scale

	} // End Scene1

} // End RandyHabenicht.CrawlWalkJogRun 
