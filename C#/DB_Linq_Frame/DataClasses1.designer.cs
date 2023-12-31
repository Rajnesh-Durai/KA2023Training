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

namespace DB_Linq_Frame
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="student")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer_Node(Customer_Node instance);
    partial void UpdateCustomer_Node(Customer_Node instance);
    partial void DeleteCustomer_Node(Customer_Node instance);
    partial void InsertRegion(Region instance);
    partial void UpdateRegion(Region instance);
    partial void DeleteRegion(Region instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DB_Linq_Frame.Properties.Settings.Default.studentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<stud_table1> stud_table1s
		{
			get
			{
				return this.GetTable<stud_table1>();
			}
		}
		
		public System.Data.Linq.Table<Customer_Node> Customer_Nodes
		{
			get
			{
				return this.GetTable<Customer_Node>();
			}
		}
		
		public System.Data.Linq.Table<Region> Regions
		{
			get
			{
				return this.GetTable<Region>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stud_table1")]
	public partial class stud_table1
	{
		
		private System.Nullable<int> _rollno;
		
		private string _stud_name;
		
		public stud_table1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rollno", DbType="Int")]
		public System.Nullable<int> rollno
		{
			get
			{
				return this._rollno;
			}
			set
			{
				if ((this._rollno != value))
				{
					this._rollno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stud_name", DbType="NVarChar(20)")]
		public string stud_name
		{
			get
			{
				return this._stud_name;
			}
			set
			{
				if ((this._stud_name != value))
				{
					this._stud_name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Nodes")]
	public partial class Customer_Node : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _node_id;
		
		private System.Nullable<int> _Region_id;
		
		private System.Nullable<int> _Customer_id;
		
		private EntityRef<Region> _Region;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onnode_idChanging(int value);
    partial void Onnode_idChanged();
    partial void OnRegion_idChanging(System.Nullable<int> value);
    partial void OnRegion_idChanged();
    partial void OnCustomer_idChanging(System.Nullable<int> value);
    partial void OnCustomer_idChanged();
    #endregion
		
		public Customer_Node()
		{
			this._Region = default(EntityRef<Region>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_node_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int node_id
		{
			get
			{
				return this._node_id;
			}
			set
			{
				if ((this._node_id != value))
				{
					this.Onnode_idChanging(value);
					this.SendPropertyChanging();
					this._node_id = value;
					this.SendPropertyChanged("node_id");
					this.Onnode_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region_id", DbType="Int")]
		public System.Nullable<int> Region_id
		{
			get
			{
				return this._Region_id;
			}
			set
			{
				if ((this._Region_id != value))
				{
					if (this._Region.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRegion_idChanging(value);
					this.SendPropertyChanging();
					this._Region_id = value;
					this.SendPropertyChanged("Region_id");
					this.OnRegion_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_id", DbType="Int")]
		public System.Nullable<int> Customer_id
		{
			get
			{
				return this._Customer_id;
			}
			set
			{
				if ((this._Customer_id != value))
				{
					this.OnCustomer_idChanging(value);
					this.SendPropertyChanging();
					this._Customer_id = value;
					this.SendPropertyChanged("Customer_id");
					this.OnCustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Region_Customer_Node", Storage="_Region", ThisKey="Region_id", OtherKey="Region_id", IsForeignKey=true)]
		public Region Region
		{
			get
			{
				return this._Region.Entity;
			}
			set
			{
				Region previousValue = this._Region.Entity;
				if (((previousValue != value) 
							|| (this._Region.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Region.Entity = null;
						previousValue.Customer_Nodes.Remove(this);
					}
					this._Region.Entity = value;
					if ((value != null))
					{
						value.Customer_Nodes.Add(this);
						this._Region_id = value.Region_id;
					}
					else
					{
						this._Region_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Region");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Regions")]
	public partial class Region : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Region_id;
		
		private string _Region1;
		
		private EntitySet<Customer_Node> _Customer_Nodes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRegion_idChanging(int value);
    partial void OnRegion_idChanged();
    partial void OnRegion1Changing(string value);
    partial void OnRegion1Changed();
    #endregion
		
		public Region()
		{
			this._Customer_Nodes = new EntitySet<Customer_Node>(new Action<Customer_Node>(this.attach_Customer_Nodes), new Action<Customer_Node>(this.detach_Customer_Nodes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Region_id
		{
			get
			{
				return this._Region_id;
			}
			set
			{
				if ((this._Region_id != value))
				{
					this.OnRegion_idChanging(value);
					this.SendPropertyChanging();
					this._Region_id = value;
					this.SendPropertyChanged("Region_id");
					this.OnRegion_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Region", Storage="_Region1", DbType="NVarChar(20)")]
		public string Region1
		{
			get
			{
				return this._Region1;
			}
			set
			{
				if ((this._Region1 != value))
				{
					this.OnRegion1Changing(value);
					this.SendPropertyChanging();
					this._Region1 = value;
					this.SendPropertyChanged("Region1");
					this.OnRegion1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Region_Customer_Node", Storage="_Customer_Nodes", ThisKey="Region_id", OtherKey="Region_id")]
		public EntitySet<Customer_Node> Customer_Nodes
		{
			get
			{
				return this._Customer_Nodes;
			}
			set
			{
				this._Customer_Nodes.Assign(value);
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
		
		private void attach_Customer_Nodes(Customer_Node entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void detach_Customer_Nodes(Customer_Node entity)
		{
			this.SendPropertyChanging();
			entity.Region = null;
		}
	}
}
#pragma warning restore 1591
