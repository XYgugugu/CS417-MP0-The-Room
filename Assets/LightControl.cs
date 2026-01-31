using UnityEngine;
using UnityEngine.InputSystem;

public class LightControl : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    public float step = 0.25f;

    float phase = 0f;

    void Start()
    {
        action.action.Enable();
        action.action.performed += _ =>
        {
            if (light == null) return;

            phase = Mathf.Repeat(phase + step, 2f);
            float p = 1f - Mathf.Abs(phase - 1f);
            light.color = Color.Lerp(Color.white, Color.red, p);
        };
    }
}
