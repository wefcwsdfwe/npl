﻿namespace SpaceBattle.Lib;

public class Vector
{
    private int[] coordinates;
    public Vector(params int[] location)
    {
        coordinates = location;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        Vector result = new Vector(new int[a.coordinates.Length]);
        result.coordinates = a.coordinates.Select((value, index) => value + b.coordinates[index]).ToArray();
        return result;
    }

    public override bool Equals(object? obj)
    {
        return obj != null && obj is Vector vector && coordinates.SequenceEqual(vector.coordinates);
    }

    public override int GetHashCode()
    {
        return coordinates.GetHashCode();
    }
}
