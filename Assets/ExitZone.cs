using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitZone : MonoBehaviour
{
    public Transform[] spawnPoints;
    public AudioSource winSound;
    public float delayBeforeReturn = 1.5f;

    private bool triggered = false;

    void Start()
    {
        // Pick a random spawn point
        int index = Random.Range(0, spawnPoints.Length);
        transform.position = spawnPoints[index].position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            StartCoroutine(WinRoutine());
        }
    }

    IEnumerator WinRoutine()
    {
        winSound.Play();
        yield return new WaitForSeconds(delayBeforeReturn);
        SceneManager.LoadScene("StartScreen");
    }
}
