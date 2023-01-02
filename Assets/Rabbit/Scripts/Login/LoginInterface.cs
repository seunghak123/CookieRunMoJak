using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface LoginInterface 
{
    void Login();
    void SignIn();
    void OnSignResult();
    bool IsInit();
    void Init();
}
