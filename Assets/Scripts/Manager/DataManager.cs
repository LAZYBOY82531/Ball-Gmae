using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    private float moveSpeed = 3;
    public float MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

    public int Score;
}