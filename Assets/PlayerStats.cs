using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour {
    new Random Würfel;

    string DD = ("Damage Dealer");


    int Armor = 0;

	// Use this for initialization
	void Start () {
		if (tag == DD)
        {
            Dice(1, 3);
            var MaxHealthDD = 7 + Armor + j;

        }
	}

    void Dice(int Min, int Max)
    {
       public int j = Würfel.Range(Min, Max);
    }
	}
	// Update is called once per frame
	void Update () {
		
	}
}

}