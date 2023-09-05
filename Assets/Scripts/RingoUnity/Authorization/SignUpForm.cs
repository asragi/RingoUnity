using System;
using RingoLib.Authorization.SignUp.Services;
using RingoLib.Core.Error;
using RingoLib.Core.Utils;
using UnityEngine;

public class SignUpForm
{
    private readonly SignUpService _service;
    private readonly Func<string> _getName;
    private readonly IIDGenerator _idGenerator;

    public SignUpForm(
	    SignUpService service,
	    Func<string> getName,
        IIDGenerator idGenerator) {
        _service = service;
        _getName = getName;
        _idGenerator = idGenerator;
    }

    public void OnSubmit() {
        string userName = _getName();
        string userId = _idGenerator.Gen();
        string loginKey = _idGenerator.Gen();
        _service.PostSignUpAsync(new(userName, userId, loginKey))
	        .ContinueWith(
		    task =>
            {
                var response = task.Result;
                var err = response.Error;
                if (err.IsError())
                {
                    OnSubmitError();
                    return;
                }
                OnSubmitComplete();
            }
	    );
    }

    private void OnSubmitComplete() { 
    
    }

    private void OnSubmitError() { 
    
    }
}
