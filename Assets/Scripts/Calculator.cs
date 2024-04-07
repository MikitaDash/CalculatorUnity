using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public float AddOne;
    public float AddTwo;
    public float ResultAddiction;

    public float SubOne;
    public float SubTwo;
    public float ResultSubtraction;

    public float MultiOne;
    public float MultiTwo;
    public float ResultMultiplication;

    public float DivOne;
    public float DivTwo;
    public float ResultDivision;

    void Start()

    {Add(); Sub(); Mult(); Div();}

    void Add()

    {ResultAddiction = AddOne + AddTwo;
        Debug.Log(ResultAddiction);}

    void Sub()

    {ResultSubtraction = SubOne - SubTwo;
        Debug.Log(ResultSubtraction);}

    void Mult()

    {ResultMultiplication = MultiOne * MultiTwo;
        Debug.Log(ResultMultiplication);}

    void Div()

    {ResultDivision = DivOne / DivTwo;
        Debug.Log(ResultDivision);}
}