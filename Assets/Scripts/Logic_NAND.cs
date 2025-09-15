using UnityEngine;

public class Logic_NAND : Logic
{
    public outputReference inputA;
    public outputReference inputB;

    void Start()
    {
        inputs = new outputReference[2];
        inputs[0] = inputA;
        inputs[1] = inputB;

        outputs = new bool[1];
        outputs[0] = false;
    }

    void Update()
    {
        outputs[0] = nand(inputA.logic.getOutput(inputA.outputIndex), inputB.logic.getOutput(inputB.outputIndex));
    }

    bool nand(bool a, bool b)
    {
        return !(a && b);
    }
}