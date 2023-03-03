using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {

    private GameObject playerObj = null;
    public GameObject RespawnPoint = null;
    private Vector3 PlayerPos = new Vector3(0, 1, 0);
    int IceCubes = 0;
    // Use this for initialization
    void Start () {
        if (playerObj == null)
            playerObj = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPos = playerObj.GetComponent<Transform>().position;
        if (PlayerPos.y < 0)
        {
            playerObj.GetComponent<Transform>().position = RespawnPoint.transform.position + new Vector3(0, 5, 0);
            playerObj.GetComponent<ThirdPersonController>().isGrounded = true;
            IceCubes = playerObj.GetComponent<GetIceCube>().iceCubes;
            if (IceCubes > 0) {
                playerObj.GetComponent<GetIceCube>().iceCubes -= 1;
            }
            
        }
	}
}
