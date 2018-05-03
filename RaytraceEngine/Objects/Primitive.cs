﻿using Engine.Objects;
using OpenTK;

namespace RaytraceEngine.Objects
{
    public interface ITraceable
    {
        bool CheckHit(Ray ray, out RayHit hit);
    }
    
    public abstract class Primitive : ITraceable
    {
        public abstract bool CheckHit(Ray ray, out RayHit hit);
    }

    public class Sphere : Primitive
    {
        public override bool CheckHit(Ray ray, out RayHit hit)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Plane : Primitive
    {
        public override bool CheckHit(Ray ray, out RayHit hit)
        {
            throw new System.NotImplementedException();
        }
    }
}