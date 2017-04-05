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

namespace NegoShoePH.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NegoShoeInventory")]
	public partial class InventoryDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertItemWithImage(ItemWithImage instance);
    partial void UpdateItemWithImage(ItemWithImage instance);
    partial void DeleteItemWithImage(ItemWithImage instance);
    #endregion
		
		public InventoryDataDataContext() : 
				base(global::NegoShoePH.Data.Properties.Settings.Default.PROD, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<ItemWithImage> ItemWithImages
		{
			get
			{
				return this.GetTable<ItemWithImage>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Items")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _ItemName;
		
		private string _Description;
		
		private int _TotalQuantity;
		
		private int _OfficeQuantity;
		
		private int _HouseQuantity;
		
		private string _Filename;
		
		private string _ImageBase64;
		
		private string _Remarks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTotalQuantityChanging(int value);
    partial void OnTotalQuantityChanged();
    partial void OnOfficeQuantityChanging(int value);
    partial void OnOfficeQuantityChanged();
    partial void OnHouseQuantityChanging(int value);
    partial void OnHouseQuantityChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    partial void OnImageBase64Changing(string value);
    partial void OnImageBase64Changed();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    #endregion
		
		public Item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalQuantity", DbType="Int NOT NULL")]
		public int TotalQuantity
		{
			get
			{
				return this._TotalQuantity;
			}
			set
			{
				if ((this._TotalQuantity != value))
				{
					this.OnTotalQuantityChanging(value);
					this.SendPropertyChanging();
					this._TotalQuantity = value;
					this.SendPropertyChanged("TotalQuantity");
					this.OnTotalQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OfficeQuantity", DbType="Int NOT NULL")]
		public int OfficeQuantity
		{
			get
			{
				return this._OfficeQuantity;
			}
			set
			{
				if ((this._OfficeQuantity != value))
				{
					this.OnOfficeQuantityChanging(value);
					this.SendPropertyChanging();
					this._OfficeQuantity = value;
					this.SendPropertyChanged("OfficeQuantity");
					this.OnOfficeQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HouseQuantity", DbType="Int NOT NULL")]
		public int HouseQuantity
		{
			get
			{
				return this._HouseQuantity;
			}
			set
			{
				if ((this._HouseQuantity != value))
				{
					this.OnHouseQuantityChanging(value);
					this.SendPropertyChanging();
					this._HouseQuantity = value;
					this.SendPropertyChanged("HouseQuantity");
					this.OnHouseQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(50)")]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageBase64", DbType="NVarChar(MAX)")]
		public string ImageBase64
		{
			get
			{
				return this._ImageBase64;
			}
			set
			{
				if ((this._ImageBase64 != value))
				{
					this.OnImageBase64Changing(value);
					this.SendPropertyChanging();
					this._ImageBase64 = value;
					this.SendPropertyChanged("ImageBase64");
					this.OnImageBase64Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="NVarChar(500)")]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemWithImage")]
	public partial class ItemWithImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _Name;
		
		private string _Filename;
		
		private string _Extension;
		
		private System.Data.Linq.Binary _Image;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    partial void OnExtensionChanging(string value);
    partial void OnExtensionChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    #endregion
		
		public ItemWithImage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extension", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Extension
		{
			get
			{
				return this._Extension;
			}
			set
			{
				if ((this._Extension != value))
				{
					this.OnExtensionChanging(value);
					this.SendPropertyChanging();
					this._Extension = value;
					this.SendPropertyChanged("Extension");
					this.OnExtensionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
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
