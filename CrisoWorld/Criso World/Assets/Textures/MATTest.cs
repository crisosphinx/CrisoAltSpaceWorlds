using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEditor;

public class MATTest : MonoBehaviour
{
    public Texture2D[] textures;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Texture2D t in textures)
        {
            WaitForSeconds
            material.SetTexture(t.name, t);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
