// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LTTransformAnimator.cs" company="Supyrb">
//   Copyright (c) 2019 Supyrb. All rights reserved.
// </copyright>
// <author>
//   Johannes Deml
//   public@deml.io
// </author>
// --------------------------------------------------------------------------------------------------------------------

using NaughtyAttributes;
using UnityEngine;

namespace Supyrb
{
	public class LTTransformAnimator : ALTAnimator
	{
		[SerializeField]
		[ReorderableList]
		private LTTransformAnimationData[] animations = null;


		protected override ILTAnimationData[] Animations => animations;
	}
}