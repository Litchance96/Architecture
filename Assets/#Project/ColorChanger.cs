using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Renderer renderer;

    public Color color;
    
    public TriggerEvent triggerEvent;
    public void ChangeColor()
    {

        renderer.material.color = color;
    }

}


