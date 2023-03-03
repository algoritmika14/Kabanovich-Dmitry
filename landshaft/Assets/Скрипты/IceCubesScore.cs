using UnityEngine;
using UnityEngine.UI;

public class IceCubesScore : MonoBehaviour
{
    public GameObject player;
    public int playerIceCubes = 0;
    public Text iceCubesScoreText;

    void Update()
    {
        playerIceCubes = player.GetComponent<GetIceCube>().iceCubes;
        //Debug.Log(playercoins.ToString());
        iceCubesScoreText.text = "Ice cubes: " + playerIceCubes.ToString();
        
    }

}