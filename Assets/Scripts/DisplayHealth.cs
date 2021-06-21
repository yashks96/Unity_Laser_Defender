using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
	TextMeshProUGUI healthText;
	Player player;
	// Start is called before the first frame update
	void Start()
	{
		healthText = GetComponent<TextMeshProUGUI>();
		player = FindObjectOfType<Player>();
	}

	// Update is called once per frame
	void Update()
	{
		int health = player.GetHealth();
		if (health < 0)
		{
			healthText.text = "0";
		}
		else
		{
			healthText.text = player.GetHealth().ToString();
		}
	}
}
