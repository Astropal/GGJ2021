using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audioDataSpace;
    AudioSource audioDataGlace;

    private void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        
        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    void Start()
    {
        audioDataSpace = gameObject.transform.Find("Space").transform.GetComponent<AudioSource>();
        audioDataGlace = gameObject.transform.Find("Glace").transform.GetComponent<AudioSource>();

        audioDataSpace.Stop();
        audioDataGlace.Stop();

        audioDataSpace.Play(0);
    }

    public void PlayGlace() {
        Debug.Log("Play glace!");
        audioDataGlace.Play(0);
        StartCoroutine(StartFade(audioDataSpace, 1, 0));
        StartCoroutine(StartFade(audioDataGlace, 1, 1));
    }

    public void PlaySpace() {
        Debug.Log("Play glace!");
        audioDataSpace.Play(0);
        StartCoroutine(StartFade(audioDataGlace, 1, 0));
        StartCoroutine(StartFade(audioDataSpace, 1, 1));
    }
}
