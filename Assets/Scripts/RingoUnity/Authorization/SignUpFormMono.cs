using RingoLib.Authorization.SignUp.Services;
using RingoUnity.DI;
using UnityEngine;
using UnityEngine.UI;

public class SignUpFormMono : MonoBehaviour
{
    [SerializeField]
    private DIComponent _diComponent;
    [SerializeField]
    private InputField _inputField;
    private SignUpForm _signUpForm;

    private void Awake()
    {
        var userAuthRepo = _diComponent.UserAuthRepository;
        var idGenerator = _diComponent.IDGenerator;
        var service = new SignUpService(userAuthRepo);
        _signUpForm = new(service, GetInputName, idGenerator);
    }

    public void OnClickButtonMono() {
        _signUpForm.OnSubmit();
    }

    private void OnSubmitComplete() { 
    
    }

    private void OnSubmitError() { 
    
    }

    private string GetInputName() {
        return _inputField.text;
    }
}
