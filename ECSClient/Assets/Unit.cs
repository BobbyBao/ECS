
using UnityEngine;
using Unity.Entities;
using System;

public struct UnitData : IComponentData
{
    public Vector3 pos;
    public float rot;
}

public class UnitSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
    }
}