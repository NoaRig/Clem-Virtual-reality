using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChooser : MonoBehaviour
{
    public MeshRenderer target;
    public Color[] colors = new Color[0];

    public void SetColor(float index)
    {
        if (index < 0 || index >= colors.Length)
        {
            return;
        }

        target.material.color = colors[(int)index];
    }
}
