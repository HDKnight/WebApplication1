﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 母版页.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MedalSystem")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedalSystemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<V_MedalSon> V_MedalSon
		{
			get
			{
				return this.GetTable<V_MedalSon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_MedalSon")]
	public partial class V_MedalSon
	{
		
		private int _Id;
		
		private string _UserId;
		
		private string _Name;
		
		private System.Nullable<int> _MedalId;
		
		private string _MedalName;
		
		private System.Nullable<double> _IntegralValue;
		
		private string _IntegralSource;
		
		private System.Nullable<System.DateTime> _WriteTime;
		
		public V_MedalSon()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="VarChar(10)")]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedalId", DbType="Int")]
		public System.Nullable<int> MedalId
		{
			get
			{
				return this._MedalId;
			}
			set
			{
				if ((this._MedalId != value))
				{
					this._MedalId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedalName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MedalName
		{
			get
			{
				return this._MedalName;
			}
			set
			{
				if ((this._MedalName != value))
				{
					this._MedalName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntegralValue", DbType="Float")]
		public System.Nullable<double> IntegralValue
		{
			get
			{
				return this._IntegralValue;
			}
			set
			{
				if ((this._IntegralValue != value))
				{
					this._IntegralValue = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntegralSource", DbType="VarChar(80)")]
		public string IntegralSource
		{
			get
			{
				return this._IntegralSource;
			}
			set
			{
				if ((this._IntegralSource != value))
				{
					this._IntegralSource = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WriteTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> WriteTime
		{
			get
			{
				return this._WriteTime;
			}
			set
			{
				if ((this._WriteTime != value))
				{
					this._WriteTime = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
