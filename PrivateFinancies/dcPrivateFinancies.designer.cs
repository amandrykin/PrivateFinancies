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

namespace PrivateFinancies
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PrivateFinancies")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertCurrency(Currency instance);
    partial void UpdateCurrency(Currency instance);
    partial void DeleteCurrency(Currency instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::PrivateFinancies.Properties.Settings.Default.PrivateFinanciesConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Item> Item
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Currency> Currency
		{
			get
			{
				return this.GetTable<Currency>();
			}
		}
		
		public System.Data.Linq.Table<Account> Account
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Items")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _Parent;
		
		private bool _IsFolder;
		
		private int _OrderNumber;
		
		private EntitySet<Item> _Item1;
		
		private EntityRef<Item> _Items1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnParentChanging(System.Nullable<int> value);
    partial void OnParentChanged();
    partial void OnIsFolderChanging(bool value);
    partial void OnIsFolderChanged();
    partial void OnOrderNumberChanging(int value);
    partial void OnOrderNumberChanged();
    #endregion
		
		public Item()
		{
			this._Item1 = new EntitySet<Item>(new Action<Item>(this.attach_Item1), new Action<Item>(this.detach_Item1));
			this._Items1 = default(EntityRef<Item>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="Int")]
		public System.Nullable<int> Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					if (this._Items1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentChanging(value);
					this.SendPropertyChanging();
					this._Parent = value;
					this.SendPropertyChanged("Parent");
					this.OnParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsFolder", DbType="Bit NOT NULL")]
		public bool IsFolder
		{
			get
			{
				return this._IsFolder;
			}
			set
			{
				if ((this._IsFolder != value))
				{
					this.OnIsFolderChanging(value);
					this.SendPropertyChanging();
					this._IsFolder = value;
					this.SendPropertyChanged("IsFolder");
					this.OnIsFolderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="Int NOT NULL")]
		public int OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Item", Storage="_Item1", ThisKey="Id", OtherKey="Parent")]
		public EntitySet<Item> Item1
		{
			get
			{
				return this._Item1;
			}
			set
			{
				this._Item1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Item", Storage="_Items1", ThisKey="Parent", OtherKey="Id", IsForeignKey=true)]
		public Item Items1
		{
			get
			{
				return this._Items1.Entity;
			}
			set
			{
				Item previousValue = this._Items1.Entity;
				if (((previousValue != value) 
							|| (this._Items1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Items1.Entity = null;
						previousValue.Item1.Remove(this);
					}
					this._Items1.Entity = value;
					if ((value != null))
					{
						value.Item1.Add(this);
						this._Parent = value.Id;
					}
					else
					{
						this._Parent = default(Nullable<int>);
					}
					this.SendPropertyChanged("Items1");
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
		
		private void attach_Item1(Item entity)
		{
			this.SendPropertyChanging();
			entity.Items1 = this;
		}
		
		private void detach_Item1(Item entity)
		{
			this.SendPropertyChanging();
			entity.Items1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currencies")]
	public partial class Currency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameShort;
		
		private string _NameFull;
		
		private int _OrderNumber;
		
		private bool _IsMain;
		
		private EntitySet<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameShortChanging(string value);
    partial void OnNameShortChanged();
    partial void OnNameFullChanging(string value);
    partial void OnNameFullChanged();
    partial void OnOrderNumberChanging(int value);
    partial void OnOrderNumberChanged();
    partial void OnIsMainChanging(bool value);
    partial void OnIsMainChanged();
    #endregion
		
		public Currency()
		{
			this._Account = new EntitySet<Account>(new Action<Account>(this.attach_Account), new Action<Account>(this.detach_Account));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameShort", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string NameShort
		{
			get
			{
				return this._NameShort;
			}
			set
			{
				if ((this._NameShort != value))
				{
					this.OnNameShortChanging(value);
					this.SendPropertyChanging();
					this._NameShort = value;
					this.SendPropertyChanged("NameShort");
					this.OnNameShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameFull", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string NameFull
		{
			get
			{
				return this._NameFull;
			}
			set
			{
				if ((this._NameFull != value))
				{
					this.OnNameFullChanging(value);
					this.SendPropertyChanging();
					this._NameFull = value;
					this.SendPropertyChanged("NameFull");
					this.OnNameFullChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="Int NOT NULL")]
		public int OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsMain", DbType="Bit NOT NULL")]
		public bool IsMain
		{
			get
			{
				return this._IsMain;
			}
			set
			{
				if ((this._IsMain != value))
				{
					this.OnIsMainChanging(value);
					this.SendPropertyChanging();
					this._IsMain = value;
					this.SendPropertyChanged("IsMain");
					this.OnIsMainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Account", Storage="_Account", ThisKey="Id", OtherKey="Currency")]
		public EntitySet<Account> Account
		{
			get
			{
				return this._Account;
			}
			set
			{
				this._Account.Assign(value);
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
		
		private void attach_Account(Account entity)
		{
			this.SendPropertyChanging();
			entity.Currency1 = this;
		}
		
		private void detach_Account(Account entity)
		{
			this.SendPropertyChanging();
			entity.Currency1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accounts")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _Currency;
		
		private System.Nullable<int> _Parent;
		
		private bool _IsFolder;
		
		private int _OrderNumber;
		
		private EntitySet<Account> _Account1;
		
		private EntityRef<Account> _Accounts1;
		
		private EntityRef<Currency> _Currency1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCurrencyChanging(System.Nullable<int> value);
    partial void OnCurrencyChanged();
    partial void OnParentChanging(System.Nullable<int> value);
    partial void OnParentChanged();
    partial void OnIsFolderChanging(bool value);
    partial void OnIsFolderChanged();
    partial void OnOrderNumberChanging(int value);
    partial void OnOrderNumberChanged();
    #endregion
		
		public Account()
		{
			this._Account1 = new EntitySet<Account>(new Action<Account>(this.attach_Account1), new Action<Account>(this.detach_Account1));
			this._Accounts1 = default(EntityRef<Account>);
			this._Currency1 = default(EntityRef<Currency>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Currency", DbType="Int")]
		public System.Nullable<int> Currency
		{
			get
			{
				return this._Currency;
			}
			set
			{
				if ((this._Currency != value))
				{
					if (this._Currency1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCurrencyChanging(value);
					this.SendPropertyChanging();
					this._Currency = value;
					this.SendPropertyChanged("Currency");
					this.OnCurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="Int")]
		public System.Nullable<int> Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					if (this._Accounts1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentChanging(value);
					this.SendPropertyChanging();
					this._Parent = value;
					this.SendPropertyChanged("Parent");
					this.OnParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsFolder", DbType="Bit NOT NULL")]
		public bool IsFolder
		{
			get
			{
				return this._IsFolder;
			}
			set
			{
				if ((this._IsFolder != value))
				{
					this.OnIsFolderChanging(value);
					this.SendPropertyChanging();
					this._IsFolder = value;
					this.SendPropertyChanged("IsFolder");
					this.OnIsFolderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="Int NOT NULL")]
		public int OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Account", Storage="_Account1", ThisKey="Id", OtherKey="Parent")]
		public EntitySet<Account> Account1
		{
			get
			{
				return this._Account1;
			}
			set
			{
				this._Account1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Account", Storage="_Accounts1", ThisKey="Parent", OtherKey="Id", IsForeignKey=true)]
		public Account Accounts1
		{
			get
			{
				return this._Accounts1.Entity;
			}
			set
			{
				Account previousValue = this._Accounts1.Entity;
				if (((previousValue != value) 
							|| (this._Accounts1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Accounts1.Entity = null;
						previousValue.Account1.Remove(this);
					}
					this._Accounts1.Entity = value;
					if ((value != null))
					{
						value.Account1.Add(this);
						this._Parent = value.Id;
					}
					else
					{
						this._Parent = default(Nullable<int>);
					}
					this.SendPropertyChanged("Accounts1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Account", Storage="_Currency1", ThisKey="Currency", OtherKey="Id", IsForeignKey=true)]
		public Currency Currency1
		{
			get
			{
				return this._Currency1.Entity;
			}
			set
			{
				Currency previousValue = this._Currency1.Entity;
				if (((previousValue != value) 
							|| (this._Currency1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Currency1.Entity = null;
						previousValue.Account.Remove(this);
					}
					this._Currency1.Entity = value;
					if ((value != null))
					{
						value.Account.Add(this);
						this._Currency = value.Id;
					}
					else
					{
						this._Currency = default(Nullable<int>);
					}
					this.SendPropertyChanged("Currency1");
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
		
		private void attach_Account1(Account entity)
		{
			this.SendPropertyChanging();
			entity.Accounts1 = this;
		}
		
		private void detach_Account1(Account entity)
		{
			this.SendPropertyChanging();
			entity.Accounts1 = null;
		}
	}
}
#pragma warning restore 1591
