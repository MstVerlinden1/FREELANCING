using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChrosshairProperties : MonoBehaviour
{
    private RectTransform rt;
    private void Start()
    {
        rt = GetComponent<RectTransform>();
    }
    public void ChangeSize(float value)
    {
        rt.sizeDelta = new Vector2(value,value);
    }
    public void ChangeLength(float value)
    {
        rt.sizeDelta = new Vector2(value,rt.sizeDelta.y);
    }
    public void ChangeThiccness(float value)
    {
        rt.sizeDelta = new Vector2(rt.sizeDelta.y, value);
    }
}
