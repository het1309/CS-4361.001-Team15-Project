using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Available,
    Current,
    Completed,
    End
}

public class MazeNode : MonoBehaviour
{
    [SerializeField] GameObject[] walls;
    [SerializeField] MeshRenderer floor;

    private NodeState state = NodeState.Available;

    public NodeState GetState()
    {
        return state;
    }

    public void RemoveWall(int wallToRemove)
    {
        walls[wallToRemove].SetActive(false);
    }

    public void SetColor(Color color)
    {
        floor.material.color = color;
    }

    public void SetState(NodeState newState)
    {
        state = newState;
        UpdateStateVisuals();
    }

    private void UpdateStateVisuals()
    {
        switch (state)
        {
            case NodeState.Available:
                SetColor(Color.white);
                break;
            case NodeState.Current:
                SetColor(Color.yellow);
                break;
            case NodeState.Completed:
                SetColor(Color.white);
                break;
            case NodeState.End:
                SetColor(Color.red);
                break;
        }
    }
}
