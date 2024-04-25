using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detection : MonoBehaviour
{
    [SerializeField] MazeNode nodePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.GetComponentInParent<MazeNode>().GetState() == NodeState.End && collision.gameObject.name == "Floor")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
