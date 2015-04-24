using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	private Vector3 rotation;

	public void Start()
	{
		this.rotation = new Vector3(15, 30, 45);
	}

	void Update()
	{
		this.transform.Rotate(this.rotation * Time.deltaTime);
	}
}
