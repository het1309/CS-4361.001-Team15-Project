using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Score")]
public class Score : ScriptableObject
{
    public const int MAX_SCORE = 1000000;
    public int score = MAX_SCORE;
}
