using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTouch : MonoBehaviour
{
    public int jumpscareIndex;
    private JumpscareManager jumpscareManager;

    void Start()
    {
        jumpscareManager = FindObjectOfType<JumpscareManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            jumpscareManager.TriggerJumpscare(jumpscareIndex);
        }
    }
}
