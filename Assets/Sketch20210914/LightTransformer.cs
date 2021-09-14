using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTransformer : MonoBehaviour
{
    public Light[] spotLights;
    public Transform target;

    private void Start()
    {
        //spotLights = GameObject.FindObjectsOfType<Light>();

        for (int i = 0; i < spotLights.Length; i++)
        {
            spotLights[i].colorTemperature = remap(i, 0, 8, 1500, 20000);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(target.transform);
        foreach (Light light in spotLights)
        {
            light.transform.LookAt(target, Vector3.right);
        }
    }

    static float remap(float ipt, float oldMin, float oldMax, float newMin, float newMax)
    {
        return ipt * (newMax - newMin) / (oldMax - oldMin) + newMin;
    }
}
