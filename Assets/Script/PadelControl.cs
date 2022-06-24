using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelControl : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    //public Vector3 arenaMax;
    //public Vector3 areaMin;
    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }
        else if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
                
        return Vector3.zero;
    }

   private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
