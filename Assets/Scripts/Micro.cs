using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Micro : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource audioSource;
    private string micDevice;
    private float[] samples = new float[1024];
    public float decibeles;
    public Transform sound;
    public Clock clock;
    public float night;
    public GameObject mic;
    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    public Player player;
    public GameObject cams;
    public float x;
    public float y;
    public float z;
    public float ench;
    public Data dt;

    void Start()
    {
        if (Microphone.devices.Length == 0)
        {
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Microphone.devices.Length > 0)
        {
            micDevice = Microphone.devices[0];
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Microphone.Start(micDevice, true, 1, 44100);
            audioSource.loop = true;

            while (!(Microphone.GetPosition(micDevice) > 0)) { }

            audioSource.Play();
        }
    }

    void Update()
    {
    ench = dt.ench;
        if(cams.activeInHierarchy)
        {
          mic.SetActive(false);
        }
        audioSource.GetOutputData(samples, 0);
        float sum = 0f;
        x = player.x2;
        y = player.y;
        z = player.z;

        for (int i = 0; i < samples.Length; i++)
        {
            sum += samples[i] * samples[i];
        }

        float rms = Mathf.Sqrt(sum / samples.Length);
        float db = ((20 * Mathf.Log10(rms / 0.1f)) + 20f) * (1 - ench/20);
        night = clock.night;
        if(db < 0)
        {
         db = 0;
        }
        sound.transform.localScale = new Vector3(x + (db * night * 3), y + (db * night * 3), z + (db * night * 3));
        

        if(db < 1)
        {
          mic.SetActive(false);
        }
        if(db > 1 && !cams.activeInHierarchy)
        {
          mic.SetActive(true);
        }
        if(db > 1 && db < 2)
        {
          v1.SetActive(false);
          v2.SetActive(false);
          v3.SetActive(false);
          v4.SetActive(false);
          v5.SetActive(false);
        }
        if(db > 2 && db < 4)
        {
          v1.SetActive(true);
          v2.SetActive(false);
          v3.SetActive(false);
          v4.SetActive(false);
          v5.SetActive(false);
        }
        if(db > 4 && db < 6)
        {
          v1.SetActive(true);
          v2.SetActive(true);
          v3.SetActive(false);
          v4.SetActive(false);
          v5.SetActive(false);
        }
        if(db > 6 && db < 8)
        {
          v1.SetActive(true);
          v2.SetActive(true);
          v3.SetActive(true);
          v4.SetActive(false);
          v5.SetActive(false);
        }
        if(db > 10 && db < 12)
        {
          v1.SetActive(true);
          v2.SetActive(true);
          v3.SetActive(true);
          v4.SetActive(true);
          v5.SetActive(false);
        }
        if(db > 12 && db < 14)
        {
          v1.SetActive(true);
          v2.SetActive(true);
          v3.SetActive(true);
          v4.SetActive(true);
          v5.SetActive(true);
        }

        if (db < 0) db = 0;

        decibeles = db;
    }
}
