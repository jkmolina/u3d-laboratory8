using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public float minIntensity = 0.25f;
    public float maxIntensity = 5f;
    public static bool active=false;
    float random;

    void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }

    void Update()
    {
        if (active)
        {
            float noise = Mathf.PerlinNoise(random, Time.time);
            GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
        }
        else
        {
            GetComponent<Light>().intensity = 0;
        }
    }
}
