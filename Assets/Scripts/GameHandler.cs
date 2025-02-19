﻿/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour {

    [SerializeField] private Snake snake;

    private LevelGrid levelGrid;

    private void Start() {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(11, 9);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

}
