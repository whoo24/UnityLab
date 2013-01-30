using UnityEngine;
using System.Collections;

public class MaterialController : MonoBehaviour {
    public Material targetMaterial;
    public Renderer RendererA;
    public Renderer RendererB;
    public Renderer RendererC;

    public enum Material_Type
    {
        Nothing,
        SharedMaterial,
        Material,
    }

    public Material_Type HowToApplyA;
    public Material_Type HowToApplyB;
    public Material_Type HowToApplyC;

    public Material_Type ChangeMaterialA;
    public Material_Type ChangeMaterialB;
    public Material_Type ChangeMaterialC;
	// Use this for initialization
	void Start () {
        ApplyMaterial(HowToApplyA, ChangeMaterialA, RendererA);
        ApplyMaterial(HowToApplyB, ChangeMaterialB, RendererB);
        ApplyMaterial(HowToApplyC, ChangeMaterialC, RendererC);
	}

    void ApplyMaterial(Material_Type materialType, Material_Type changeMaterialType, Renderer renderer)
    {
        if (materialType == Material_Type.SharedMaterial)
        {
            renderer.sharedMaterial = targetMaterial;
        }
        else if (materialType == Material_Type.Material)
        {
            renderer.material = targetMaterial;
        }

        if (changeMaterialType == Material_Type.SharedMaterial)
        {
            renderer.sharedMaterial.mainTextureOffset = new Vector2(0.25f, 0);
        }
        else if (changeMaterialType == Material_Type.Material)
        {
            renderer.material.mainTextureOffset = new Vector2(0, 0.25f);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
