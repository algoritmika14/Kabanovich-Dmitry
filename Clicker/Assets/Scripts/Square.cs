using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 targetPosition;

    public float moveStep;

    Vector2 GetRandomPoint ()

    {
        Vector2 randomvector = new Vector2();

        randomVector.x = random.Range(-6, 6);
        randomVector.y = random.Range(-3, 3);


    }
}
