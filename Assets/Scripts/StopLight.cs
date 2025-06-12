using System.Collections;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public Renderer redLight;
    public Renderer yellowLight;
    public Renderer greenLight;

    public Material StopLightStop;
    public Material StopLightCaution;
    public Material StopLightGo;
    public Material StopLightOff;

    public float redTime = 5f;
    public float greenTime = 5f;
    public float yellowTime = 2f;

    private void Start()
    {
        StartCoroutine(StopLightCycle());
    }

    private IEnumerator StopLightCycle()
    {
        while (true)
        {
            // RED light on
            SetLights(StopLightStop, StopLightOff, StopLightOff);
            yield return new WaitForSeconds(redTime);

            // GREEN light on
            SetLights(StopLightOff, StopLightOff, StopLightGo);
            yield return new WaitForSeconds(greenTime);

            // YELLOW light on
            SetLights(StopLightOff, StopLightCaution, StopLightOff);
            yield return new WaitForSeconds(yellowTime);
        }
    }

    private void SetLights(Material red, Material yellow, Material green)
    {
        redLight.material = red;
        yellowLight.material = yellow;
        greenLight.material = green;
    }

    void Update()
    {
        
    }
}
