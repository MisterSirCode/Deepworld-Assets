using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredULong
	{
		private ObscuredULong(ulong value) : this()
		{
		}

		[SerializeField]
		private ulong currentCryptoKey;
		[SerializeField]
		private ulong hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private ulong fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	}
}
