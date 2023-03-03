using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    //дай хилку npc
    public int health = 10;

    //демон в гд npc
    public int level = 1;

    //a-train npc
    public float speed = 1.2f ;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }


    // Update is called once per frame
    void Update()
    {

    }
}