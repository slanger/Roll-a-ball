using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject Player;

	private Vector3 offset;

	void Start()
	{
		this.offset = this.transform.position;
	}
	
	void LateUpdate()
	{
		this.transform.position = this.Player.transform.position + this.offset;
	}
}
