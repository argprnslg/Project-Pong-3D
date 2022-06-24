using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;
    public Collider gawang1;
    public Collider gawang2;
    public Collider gawang3;
    public Collider gawang4;
    public SpawnManager manager;
    public ScoreManager ScoreManager;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    public float maxSpeed = 20f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Padel" || other.gameObject.tag == "BallSpawner")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == gawang1)
        {
            ScoreManager.AddScoreplayerKanan(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang2)
        {
            ScoreManager.AddScoreplayerKiri(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang3)
        {
            ScoreManager.AddScoreplayerBawah(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang4)
        {
            ScoreManager.AddScoreplayerAtas(1);
            manager.RemoveBall(gameObject);
        }
    }
}
