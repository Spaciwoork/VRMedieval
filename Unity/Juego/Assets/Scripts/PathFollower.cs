using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node [] PathNode;
    // The object who move along the path
    public GameObject Npc;
    // The speed when moving along the path
    public float MoveSpeed;
    // Default time
    float Timer;
    // Hold current node
    int CurrentNode;
    // The vector holds node position
    static Vector3 CurrentPositionHolder;
    // Start is called before the first frame update

    //
    void Start()
    {
        PathNode = GetComponentsInChildren<Node> ();
        CheckNode();
    }

    // Check current node and move to it, by save the node to CurrentPositionHolder
    void CheckNode() {
        Timer = 0;
        CurrentPositionHolder = PathNode [CurrentNode].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Current Node: " + CurrentNode);
        Timer = Time.deltaTime * MoveSpeed;
        if (Npc.transform.position != CurrentPositionHolder) {
            Npc.transform.position = Vector3.MoveTowards (Npc.transform.position, CurrentPositionHolder, Timer);
        } else {
            if (CurrentNode < PathNode.Length - 1) {
                CurrentNode++;
                CheckNode();
            }
        }
    }
}
