using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameSceneFlow : MonoBehaviour
{
    public UnityEvent OnWinGame;

    private void Start()
    {
        GameManager.Data.Score = 0;
    }

    private void Update()
    {
        if (GameManager.Data.Score == 11)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        OnWinGame?.Invoke();
    }
}