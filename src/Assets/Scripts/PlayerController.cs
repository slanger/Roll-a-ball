using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float Speed;
	public GUIText CountText;
	public GUIText WinText;

	private int count;

	public void Start()
	{
		this.WinText.gameObject.SetActive(false);
		this.count = 0;
		this.UpdateUI();
	}

	public void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody>().AddForce(movement * this.Speed * Time.deltaTime);
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			this.count++;
			this.UpdateUI();
		}
	}

	private void UpdateUI()
	{
		this.CountText.text = "Count " + this.count;
		if (this.count >= 12)
		{
			this.WinText.gameObject.SetActive(true);
		}
	}
}
