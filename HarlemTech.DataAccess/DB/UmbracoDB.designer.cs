﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HarlemTech.DataAccess.DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="harlemtATE5cogWV")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertcmsContentXml(cmsContentXml instance);
    partial void UpdatecmsContentXml(cmsContentXml instance);
    partial void DeletecmsContentXml(cmsContentXml instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::HarlemTech.DataAccess.Properties.Settings.Default.harlemtATE5cogWVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cmsContentXml> cmsContentXmls
		{
			get
			{
				return this.GetTable<cmsContentXml>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cmsContentXml")]
	public partial class cmsContentXml : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nodeId;
		
		private string _xml;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnodeIdChanging(int value);
    partial void OnnodeIdChanged();
    partial void OnxmlChanging(string value);
    partial void OnxmlChanged();
    #endregion
		
		public cmsContentXml()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int nodeId
		{
			get
			{
				return this._nodeId;
			}
			set
			{
				if ((this._nodeId != value))
				{
					this.OnnodeIdChanging(value);
					this.SendPropertyChanging();
					this._nodeId = value;
					this.SendPropertyChanged("nodeId");
					this.OnnodeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xml", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string xml
		{
			get
			{
				return this._xml;
			}
			set
			{
				if ((this._xml != value))
				{
					this.OnxmlChanging(value);
					this.SendPropertyChanging();
					this._xml = value;
					this.SendPropertyChanged("xml");
					this.OnxmlChanged();
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