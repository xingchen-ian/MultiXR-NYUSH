using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEmission : MonoBehaviour
{
    public float speed = 1.0f;
    public float minEmission = 0.0f;
    public float maxEmission = 1.0f;
    public Color color = Color.white;

    private List<Material> materials = new List<Material>();

    void Start()
    {
        //Debug.Log("Script Started.");
        GatherMaterials(transform);
        //Debug.Log("Total Materials: " + materials.Count);
        StartCoroutine(Flicker());
    }

    void GatherMaterials(Transform t)
    {
        Renderer rend = t.GetComponent<Renderer>();
        
        if (rend != null)
        {
            bool hasEmission = rend.material.HasProperty("_EmissionColor");
            //Debug.Log($"GameObject {t.name} has emission: {hasEmission}");

            if (hasEmission)
            {
                materials.Add(rend.material);
                //Debug.Log($"Added material: {rend.material.name}");
            }
        }

        foreach (Transform child in t)
        {
            GatherMaterials(child);
        }
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            float lerp = Mathf.PingPong(Time.time * speed, 1);
            Color lerpedColor = Color.Lerp(color * minEmission, color * maxEmission, lerp);
            
            //Debug.Log("Lerped Color: " + lerpedColor);

            foreach (Material mat in materials)
            {
                mat.EnableKeyword("_EMISSION");
                mat.SetColor("_EmissionColor", lerpedColor);
            }

            yield return null;
        }
    }
}