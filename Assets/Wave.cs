using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
public class Wave : MonoBehaviour
{
    void Start()
    {
        var rend = GetComponent<MeshRenderer>();
        if (rend != null && rend.material != null)
        {
            rend.material.SetFloat("_Speed", 2f);
        }
    }
}
