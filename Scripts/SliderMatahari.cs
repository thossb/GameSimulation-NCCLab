using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMatahari : MonoBehaviour
{
    /*public Vector3 rotation;*/
    public Slider sliderX;
    public Slider sliderY;

    private float angleSliderNumber;
    private float angleSliderNumber2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.visible == true)
        {
            /*transform.localRotation = Quaternion.Euler(rotation);*/

            angleSliderNumber = sliderX.value * 1f;
            angleSliderNumber2 = sliderY.value * 1f;
            this.transform.rotation = Quaternion.Euler(angleSliderNumber, angleSliderNumber2, 0);

        }
    }
}
