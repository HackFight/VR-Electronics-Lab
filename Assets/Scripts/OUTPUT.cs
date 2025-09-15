using UnityEngine;

[RequireComponent(typeof(Logic))]
[RequireComponent(typeof(Renderer))]
public class OUTPUT : MonoBehaviour
{
    Logic logic_;
    Renderer renderer_;

    void Start()
    {
        logic_ = GetComponent<Logic>();
        renderer_ = GetComponent<Renderer>();
    }

    void Update()
    {
        if (logic_.getOutput(0))
        {
            renderer_.material.color = Color.red;
        }
        else
        {
            renderer_.material.color = Color.black;
        }
    }
}