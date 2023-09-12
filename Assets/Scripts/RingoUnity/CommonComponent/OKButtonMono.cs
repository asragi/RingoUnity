using System;
using UnityEngine;

public class OKButtonMono : MonoBehaviour
{
    private Action _onSubmit;
    internal void Initialize(Action onSubmit)
    {
        _onSubmit = onSubmit;
    }
    
    public void OnSubmit() => _onSubmit();
}
