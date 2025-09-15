using UnityEngine;

public class Logic_IN : Logic
{
    void Start()
    {
        inputs = new outputReference[0];
        outputs = new bool[1];
        outputs[0] = false;
    }

    public void toggleInput()
    {
        outputs[0] = !outputs[0];
    }
}