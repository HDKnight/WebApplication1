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
	public partial class V_RJYLYLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public V_RJYLYLinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedalSystemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public V_RJYLYLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public V_RJYLYLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public V_RJYLYLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public V_RJYLYLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<V_RJYLY> V_RJYLY
		{
			get
			{
				return this.GetTable<V_RJYLY>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_RJYLY")]
	public partial class V_RJYLY
	{
		
		private System.Nullable<long> _排名;
		
		private string _员工编号;
		
		private string _姓名;
		
		private System.Nullable<double> _积分数;
		
		private System.Nullable<int> _时间;
		
		public V_RJYLY()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_排名", DbType="BigInt")]
		public System.Nullable<long> 排名
		{
			get
			{
				return this._排名;
			}
			set
			{
				if ((this._排名 != value))
				{
					this._排名 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_员工编号", DbType="VarChar(10)")]
		public string 员工编号
		{
			get
			{
				return this._员工编号;
			}
			set
			{
				if ((this._员工编号 != value))
				{
					this._员工编号 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_姓名", DbType="VarChar(20)")]
		public string 姓名
		{
			get
			{
				return this._姓名;
			}
			set
			{
				if ((this._姓名 != value))
				{
					this._姓名 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_积分数", DbType="Float")]
		public System.Nullable<double> 积分数
		{
			get
			{
				return this._积分数;
			}
			set
			{
				if ((this._积分数 != value))
				{
					this._积分数 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_时间", DbType="Int")]
		public System.Nullable<int> 时间
		{
			get
			{
				return this._时间;
			}
			set
			{
				if ((this._时间 != value))
				{
					this._时间 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
