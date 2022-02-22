using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyEdgeDetection : MonoBehaviour
{
    public Material material;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
