using System;
using UnityEngine;

using EaseFunc = System.Func<float, float, float, float, float>;

namespace RingoUnity.Utils
{
    internal static class MonoEasing
    {
        internal static EaseFuncs CreateEaseFunc(
            Vector2 targetDelta,
            int duration,
            EaseFunc easeFunc
            )
        {
            EaseMode easeMode = EaseMode.None;
            float t = 0;
            void Move() => easeMode = EaseMode.Move;
            void Back() => easeMode = EaseMode.Back;
            Vector2 Update()
            {
                if (easeMode == EaseMode.None) { return Vector2.zero; }
                if (easeMode == EaseMode.Move) t++;
                if (easeMode == EaseMode.Back) t--;
                if (t <= 0) return Vector2.zero;
                if (t > duration) return targetDelta;
                return new(
                    easeFunc(t, duration, targetDelta.x, 0),
                    easeFunc(t, duration, targetDelta.y, 0)
                    );
            }
            return new(Move, Back, Update);
        }

        internal static EaseFuncsFloat CreateEaseFunc(
            float target,
            int duration,
            EaseFunc easeFunc
            )
        {
            EaseMode easeMode = EaseMode.None;
            float t = 0;
            void Move() => easeMode = EaseMode.Move;
            void Back() => easeMode = EaseMode.Back;
            float Update()
            {
                if (easeMode == EaseMode.None) { return 0; }
                if (easeMode == EaseMode.Move) t++;
                if (easeMode == EaseMode.Back) t--;
                if (t <= 0) return 0;
                if (t > duration) return target;
                return (float)easeFunc(t, duration, target, 0);
            }
            return new(Move, Back, Update);
        }

        internal readonly struct EaseFuncs
        {
            internal EaseFuncs(Action move, Action back, Func<Vector2> update)
            {
                Move = move;
                Back = back;
                Update = update;
            }

            internal Action Move { get; }
            internal Action Back { get; }
            internal Func<Vector2> Update { get; }
        }

        internal readonly struct EaseFuncsFloat
        {
            internal EaseFuncsFloat(Action move, Action back, Func<float> update)
            {
                Move = move;
                Back = back;
                Update = update;
            }

            internal Action Move { get; }
            internal Action Back { get; }
            internal Func<float> Update { get; }
        }
        
        private enum EaseMode
        {
            None = 0,
            Move,
            Back,
        }
    }
}