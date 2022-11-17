using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleSeclector : MonoBehaviour
{
    public float maxAngle;
    public float minAngle;

    public float anglefloat;
    public Transform angleHandel;
    public Text angleValue;

    public float sliderValue;
    public float SliderSenstivity = 2;

    Quaternion startRotQuat, endRotQuat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxisRaw("Horizontal");

        if(input == 1)
        {
            sliderValue += 1 * SliderSenstivity;
            sliderValue = Mathf.Clamp(sliderValue, minAngle, maxAngle);
        }
        if(input == -1)
        {
            sliderValue -= 1 * SliderSenstivity;
            sliderValue = Mathf.Clamp(sliderValue, minAngle, maxAngle);
        }

        Debug.Log(input);

        angleValue.text = sliderValue.ToString();
        transform.rotation = Quaternion.Euler(0, 0, sliderValue);

        /*
        anglefloat = Mathf.Lerp(maxAngle, minAngle, sliderValue);
        angleHandel.transform.rotation = Quaternion.Euler(0, 0, anglefloat);
        //try lerp*/
    }
}
