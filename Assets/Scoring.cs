using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField] Score score;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "GAME OVER!!!!!!!!!\nYour Score is " + score.score + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
