using UnityEngine;

public class DissolveTrigger : MonoBehaviour
{
    private static readonly int DissolveTriggerPropertyId = Shader.PropertyToID("Vector1_195A31D6");

    [SerializeField]
    private SkinnedMeshRenderer meshRenderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            meshRenderer.material.SetFloat(DissolveTriggerPropertyId, Time.time);
        }
    }
}
