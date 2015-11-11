﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="arduino")]
	public partial class UsuariosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertusuario(usuario instance);
    partial void Updateusuario(usuario instance);
    partial void Deleteusuario(usuario instance);
    #endregion
		
		public UsuariosDataContext() : 
				base(global::Repositorio.Properties.Settings.Default.arduinoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UsuariosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsuariosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsuariosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsuariosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<usuario> usuarios
		{
			get
			{
				return this.GetTable<usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _code;
		
		private string _nombre;
		
		private string _vencido;
		
		private System.Nullable<int> _multas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodeChanging(string value);
    partial void OncodeChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnvencidoChanging(string value);
    partial void OnvencidoChanged();
    partial void OnmultasChanging(System.Nullable<int> value);
    partial void OnmultasChanged();
    #endregion
		
		public usuario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this.OncodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("code");
					this.OncodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vencido", DbType="VarChar(15)")]
		public string vencido
		{
			get
			{
				return this._vencido;
			}
			set
			{
				if ((this._vencido != value))
				{
					this.OnvencidoChanging(value);
					this.SendPropertyChanging();
					this._vencido = value;
					this.SendPropertyChanged("vencido");
					this.OnvencidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_multas", DbType="Int")]
		public System.Nullable<int> multas
		{
			get
			{
				return this._multas;
			}
			set
			{
				if ((this._multas != value))
				{
					this.OnmultasChanging(value);
					this.SendPropertyChanging();
					this._multas = value;
					this.SendPropertyChanged("multas");
					this.OnmultasChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
