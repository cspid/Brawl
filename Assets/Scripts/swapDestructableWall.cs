using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapDestructableWall : MonoBehaviour
{

	public bool isBroken;
	//public Transform brokenVersion;

	void OnCollisionEnter(Collision other)
	{
		if (isBroken == false)
			if (other.gameObject.layer == 9)
			{
                this.GetComponent<Collider>().isTrigger = true;
				for (int i = 0; i < transform.childCount; i++)
				{
					transform.GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
					if (i == transform.childCount - 1) isBroken = true;

				}
			}
	}
}
