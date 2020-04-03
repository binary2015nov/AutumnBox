﻿/*

* ==============================================================================
*
* Filename: IRegisterableLake
* Description: 
*
* Version: 1.0
* Created: 2020/3/30 13:24:43
* Compiler: Visual Studio 2019
*
* Author: zsh2401
*
* ==============================================================================
*/
using System;

namespace AutumnBox.OpenFramework.Leafx
{
    public interface IRegisterableLake : ILake
    {
        void Register(string id,Func<object> factory);
        void Register(Type type, Func<object> factory);
    }
}