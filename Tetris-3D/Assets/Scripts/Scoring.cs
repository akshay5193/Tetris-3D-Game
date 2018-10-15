﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour {

    public int level, rows, points;
    public TMP_Text scoreText, levelText, rowText;
    // Use this for initialization
    void Start()
    {
        level = 0;
        rows = 0;
        points = 0;
        setNewSpeed();
    }

    //Link - http://www.colinfahey.com/tetris/tetris.html
    public void setNewSpeed()
    {
        gameObject.GetComponent<Movement>().timestep = ((10 - level) * 0.05F);
    }

    //Link - http://tetris.wikia.com/wiki/Scoring
    public void addPointsForLines(int lines)
    {
        if (lines > 0)
        {
            switch (lines)
            {
                case 1:
                    points += 40 * (level + 1);
                    break;
                case 2:
                    points += 100 * (level + 1);
                    break;
                case 3:
                    points += 300 * (level + 1);
                    break;
                case 4:
                    points += 1200 * (level + 1);
                    break;
            }
            rows += lines;
            level = (int)rows / 10;
            setNewSpeed();
            transmitToUI();
        }
    }

    //Add points for each group which was added
    public void addPointsForCubes()
    {
        points += 4;
        transmitToUI();
    }

    public void transmitToUI()
    {
        scoreText.text = points.ToString();
        levelText.text = level.ToString();
        rowText.text = rows.ToString();
    }
}
