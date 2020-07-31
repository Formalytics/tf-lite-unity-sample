﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TensorFlowLite
{
    public static class MathTF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sigmoid(float x)
        {
            return (1.0f / (1.0f + Mathf.Exp(-x)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Leap3(in Vector3 a, in Vector3 b, in Vector3 t)
        {
            return new Vector3(
                Mathf.Lerp(a.x, b.x, t.x),
                Mathf.Lerp(a.y, b.y, t.y),
                Mathf.Lerp(a.z, b.z, t.z)
            );
        }

        public static IEnumerable<float> Softmax(this IEnumerable<float> arr)
        {
            float max = arr.Max();
            var expArr = arr.Select(n => Mathf.Exp(n - max));
            var sum = expArr.Sum();
            return expArr.Select(n => n / sum);
        }

        public static IEnumerable<double> Softmax(this IEnumerable<double> arr)
        {
            double max = arr.Max();
            var expArr = arr.Select(n => Math.Exp(n - max));
            var sum = expArr.Sum();
            return expArr.Select(n => n / sum);
        }
    }
}
