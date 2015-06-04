﻿
using System;
using System.Collections.Generic;

using System.ComponentModel;

namespace Entidades
{
  /// <summary>
  /// Representa a una Persona que puede conectarse al sistema y puede interactuar con el mismo
  /// </summary>
  public class Usuario : INotifyPropertyChanged
  {
    private string _login;

    /// <summary>
    /// Representa el ID unico de usuario dentro del sistema
    /// El ingreso al mismo debe realizarse con este identificador
    /// </summary>
    public string Login
    {
      get { return _login; }
      set
      {
        _login = value;
        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Login"));
      }
    }

    /// <summary>
    /// Si corresponde, la fecha en que expira la password del usuario
    /// </summary>
    public DateTime FechaExpiracionPassword { get; set; }

    /// <summary>
    /// Fecha/Hora de la ultima conexion exitosa del usuario
    /// </summary>
    public DateTime FechaLastLogin { get; set; }

    /// <summary>
    /// Indica si el usuario debe cambiar su contraseña la proxima vez que ingrese
    /// </summary>
    public bool MustChangePass { get; set; }

    /// <summary>
    /// Indica si se debe obligar al usuario a cambiar su contraseña luego de un lapso de tiempo establecido por el sistema
    /// </summary>
    public bool EnforceExpiration { get; set; }

    /// <summary>
    /// Indica si se la password del usuario tiene que cumplir con las restricciones de seguridad establecidas por el sistema
    /// </summary>
    public bool EnforceStrong { get; set; }

    /// <summary>
    /// Indica si el usuario esta habilitado para ingresar al sistema
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Referencia a la persona que esta representando el usuario
    /// </summary>
    public Persona Persona { get; set; }

    public List<Perfil> Perfiles { get; set; }

    //  TODO agregar propiedad de ultimo login NO EXITOSO
    //  TODO agregar propiedad imagen del usuario (no lo ponemos en Persona, solamente usuarios del sistema que tienen oportunidad de mostrarla)
    //  

    public event PropertyChangedEventHandler PropertyChanged;

  }
}