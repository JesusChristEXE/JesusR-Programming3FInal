using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpscareManager : MonoBehaviour
{
    public GameObject[] jumpscareImages;
    public AudioSource[] jumpscareSounds;
    public float jumpscareDuration = 1.5f;

    private bool triggered = false;

    public void TriggerJumpscare(int index)
    {
        if (triggered) return;
        triggered = true;

        StartCoroutine(JumpscareRoutine(index));
    }

    IEnumerator JumpscareRoutine(int index)
    {
        jumpscareImages[index].SetActive(true);
        jumpscareSounds[index].Play();

        yield return new WaitForSeconds(jumpscareDuration);

        SceneManager.LoadScene("StartScreen");
    }

}
