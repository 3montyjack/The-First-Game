using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    PlayerClass player;
    public GameObject playerSprite;

	// Use this for initialization
	void Start () {
        player = new PlayerClass();

	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        if(x > 0)
        {
            playerSprite.
        } else if (x < 0)
        {

        } else if (y > 0)
        {

        } else if (y < 0)
        {

        } else
        {

        }

        playerSprite.transform.Translate( x, y, 0 );
    }
}
