using System;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public outputReference[] inputs;
    public bool[] outputs;

    public bool getOutput(int i)
    {
        return outputs[i];
    }
}

[Serializable]
public struct outputReference
{
    public Logic logic;
    public int outputIndex;
}