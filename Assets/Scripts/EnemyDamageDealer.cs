using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageDealer : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] int laserDamage = 50;
	[SerializeField] int missileDamage = 100;
	[SerializeField] int playerDamage = 200;


	// Start is called before the first frame update
	public int GetLaserDamage()
	{
		return laserDamage;
	}
	public int GetMissileDamage()
	{
		return missileDamage;
	}
	public int GetPlayerDamage()
	{
		return playerDamage;
	}
	public void Hit()
	{
		Destroy(gameObject);
	}
}
