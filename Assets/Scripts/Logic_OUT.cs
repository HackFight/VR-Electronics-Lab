using UnityEngine;

public class Logic_OUT : Logic
{
    public outputReference input;

    void Start()
    {
        inputs = new outputReference[1];
        inputs[0] = input;

        outputs = new bool[1];
        outputs[0] = false;
    }

    void Update()
    {
        outputs[0] = inputs[0].logic.getOutput(inputs[0].outputIndex);
    }
}
