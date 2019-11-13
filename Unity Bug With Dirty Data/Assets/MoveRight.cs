using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
#pragma warning disable CS0649
    [SerializeField]
    Rigidbody2D myRB;
#pragma warning restore CS0649
    // Update is called once per frame
    void Update()
    {
        myRB.velocity = Vector2.right;
    }
}
