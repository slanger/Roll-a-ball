using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float Speed;
	public GUIText CountText;
	public GUIText WinText;

	private const string CountTextPrefix = "Count: ";
	private int count;

	public void Start()
	{
		count = 0;
		CountText.text = CountTextPrefix + count;
		WinText.gameObject.SetActive (false);
	}

	public void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody>().AddForce(movement * Speed * Time.deltaTime);
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count++;
			CountText.text = CountTextPrefix + count;
			if (count >= 12)
			{
				WinText.gameObject.SetActive(true);
			}
		}
	}
}
