using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour {

	public static bool allCollected = false;
    private void Start()
    {
		allCollected = false;
    }
    void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "pacman")
		{
			GameManager.score += 10;
		    GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            Destroy(gameObject);

		    if (pacdots.Length == 1)
		    {
				allCollected = true;
			}
		}
	}

}
