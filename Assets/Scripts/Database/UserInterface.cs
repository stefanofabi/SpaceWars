using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface UserInterface
{

    bool createUser(string email, string password);
    bool loginUser(string email, string password);
}
