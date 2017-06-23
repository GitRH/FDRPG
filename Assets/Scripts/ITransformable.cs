//
// ITransformable.cs
// The purpose of this Interface script is to have an Interface for transforming
// GameObjects
// Created by: Randy Habenicht 2/10/2017
// Modified by: Randy Habenicht 2/10/2017

using UnityEngine;
using System.Collections;

namespace RandyHabenicht.FDRPG {

	public interface ITransformable<T> {
		void Move (float x, float y, float z);
		void Rotate (float x, float y, float z);
		void Scale (float x, float y, float z);
		void Report();
	} // End ITransformable

} // End RandyHabenicht.FDRPG
