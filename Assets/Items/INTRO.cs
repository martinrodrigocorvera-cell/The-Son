using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class INTRO : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public AudioSource audioSource;
    public GameObject inter;
    public AudioClip sparks;
    public AudioClip thunder;
    public AudioClip gam;
    public string SampleScene;
    public GameObject vid;
public float fadeDuration = 4.8f;
public Texture2D cursorTexture;

    // Start is called before the first frame update
    void Start()
    {
Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        if (rawImage != null)
            rawImage.enabled = false;

        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();
            videoPlayer.prepareCompleted += OnVideoPrepared;
        }
    }

    // Update is called once per frame
    void Update()
    {
if (!audioSource.isPlaying)
{
 audioSource.Play();
}
        Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnVideoPrepared(VideoPlayer vp)
    {
        if (rawImage != null)
        {
            rawImage.enabled = true;
            vp.Play();
        Invoke("sp", 0.4f);
        Invoke("th", 1.2f);
        Invoke("st", 5f);
        Invoke("vn", 6f);
        }
    }
    void sp()
    {
     audioSource.clip = sparks;
    }
    void th()
    {
     audioSource.clip = thunder;
        StartCoroutine(FadeOutCoroutine());
    }
    void st()
    {
       inter.SetActive(true);
    }
    void vn()
    {
      vid.SetActive(false);
      SceneManager.LoadScene(SampleScene);
    }

    private IEnumerator FadeOutCoroutine()
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeDuration;
            yield return null;
        }

        audioSource.volume = 0;
        audioSource.Stop();
    }
}
