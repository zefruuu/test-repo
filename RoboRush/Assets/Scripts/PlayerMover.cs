using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float speedMove;
    [SerializeField] private float speedSide;
    [SerializeField] private float gravity;
    [SerializeField] private float lineToMove = 1;
    [SerializeField] private float lineDistance;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    private void Update()
    {
        controller.Move(new Vector3(0, gravity, speedMove) * Time.deltaTime);

        Vector3 targetPos = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (lineToMove == 0 )
        {
            targetPos += Vector3.left * lineDistance;

        }
        else if (lineToMove == 2 ) { }
        targetPos += Vector3.right * lineDistance;

    }
}
