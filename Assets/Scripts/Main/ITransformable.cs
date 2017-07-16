// ITransformable.cs
// The purpose of this Interface is to have an Interface for transforming
// GameObjects
// Created by: RH February 10, 2017
// Modified by: RH July 16, 2017

namespace RH.FDRPG {

	public interface ITransformable<T> {
		
		// all GameObjects can be moved
		void Move (float x, float y, float z);

		// all GameObjects can be rotated
		void Rotate (float x, float y, float z);

		// all GameObjects can be scaled
		void Scale (float x, float y, float z);

		// all GameObjects can have their status reported in the console
		void Report();

	} // end ITransformable

} // end RH.FDRPG
